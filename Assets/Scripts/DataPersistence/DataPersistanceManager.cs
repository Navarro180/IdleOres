using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPersistanceManager : MonoBehaviour
{
    [Header("Debugging")]
    [SerializeField] private bool initializeDataIfNull = false;
    [SerializeField] private bool disableDataPersistance = false;
    [SerializeField] private bool overrideSelectedProfileId = false;
    [SerializeField] private string testSelectedProfileId = "test";

    [Header("File Storage Config")]
    [SerializeField] private string fileName;
    [SerializeField] private bool useEncryption;

    private GameData gameData;

    private List<IDataPersistance> dataPersistanceObjects;

    public static DataPersistanceManager instance { get; private set; }

    private FileDataHandler dataHandler;

    private string selectedProfileId = "";

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persistance Manager in the scene. Destroying the newest one");
            Destroy(this.gameObject);
            return;
        } 
        instance = this;

        DontDestroyOnLoad(this.gameObject);

        if (disableDataPersistance)
        {
            Debug.LogWarning("Data Persistence is currently disabled!");
        }

        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName, useEncryption);

        InitializeSelectedProfileId();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        //SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        //SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded Called");
        this.dataPersistanceObjects = FindAllDataPersistanceObjects();
        LoadGame();
    }

    //public void OnSceneUnloaded(Scene scene)
    //{
    //    Debug.Log("OnSceneUnloaded");
    //    SaveGame();
    //}

    //load game from startup
    //private void Start()
    //{
    //    //move this to awake
    //    //this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName, useEncryption);

    //    //move this to the OnSceneLoaded
    //    //this.dataPersistanceObjects = FindAllDataPersistanceObjects();
    //    //LoadGame();
    //}

    //only use if multipe save lots
    public void ChangeSelectedProfileId(string newProdileId)
    {
        //update the profile to use for saving and loading
        this.selectedProfileId = newProdileId;

        //load the game, which will use that profile, updating our game data accordingly
        LoadGame();
    }

    public void DeleteProfileData(string profileId)
    {
        //delete the data for this profile id
        dataHandler.Delete(profileId);

        //initialize the selected profile id
        InitializeSelectedProfileId();

        //reload the game so that the data matches the newly slected profile id
        LoadGame();
    }

    private void InitializeSelectedProfileId()
    {
        this.selectedProfileId = dataHandler.GetMostRecentlyUpdatedProfileId();
        if (overrideSelectedProfileId)
        {
            this.selectedProfileId = testSelectedProfileId;
            Debug.LogWarning("Overrode selected profile id with test id: " + testSelectedProfileId);
        }
    }

    #region NewGame
    public void NewGame()
    {
        this.gameData = new GameData();
    }
    #endregion

    #region Save/Load
    public void SaveGame()
    {
        //return right away if data persistence is disabled
        if (disableDataPersistance)
        {
            return;
        }

        //if we don't have any data to save, log a warning here
        if (this.gameData == null)
        {
            Debug.Log("No data was found. A new game needs to be started before data can be loaded.");
            //NewGame();
            return;
        }

        //pass the data to other scripts so they can update it
        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            dataPersistanceObj.SaveData(gameData);
        }

        Debug.Log("Saved current health = " + gameData.playerHealth);

        //timestamp the data so known when it last saved
        gameData.lastUpdated = System.DateTime.Now.ToBinary();

        //save that data to a file using the data handler
        dataHandler.Save(gameData, selectedProfileId);
    }

    public void LoadGame()
    {
        //return right away if data persistence is disabled
        if (disableDataPersistance)
        {
            return;
        }

        //load any saved data from a file using the data handler
        this.gameData = dataHandler.Load(selectedProfileId);

        //start a new game if the data is null and we're configured to initialize data for debugging purposes
        if (this.gameData == null && initializeDataIfNull)
        {
            NewGame();
        }

        //if no data can be loaded, initialize to a new game
        if (this.gameData == null)
        {
            Debug.Log("No data was found. A new game needs to be started before data can be loaded.");
            //NewGame();
            return;
        }

        //push the loaded data to all other scripts that need it
        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            dataPersistanceObj.LoadData(gameData);
        }

        Debug.Log("Loaded current health = " + gameData.playerHealth);
    }
    #endregion

    //gets called any time the game exits
    private void OnApplicationQuit()
    {
        //save the game anytime before loading a new scene
        DataPersistanceManager.instance.SaveGame();
        //SaveGame();
    }

    private List<IDataPersistance> FindAllDataPersistanceObjects()
    {
        IEnumerable<IDataPersistance> dataPersistanceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();

        return new List<IDataPersistance>(dataPersistanceObjects);
    }

    public bool HasGameData()
    {
        return gameData != null;
    }

    //only use for multiple save lots
    public Dictionary<string, GameData> GetAllProfilesGameData()
    {
        return dataHandler.LoadAllProfiles();
    }
}
