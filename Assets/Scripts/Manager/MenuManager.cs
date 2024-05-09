using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("Menu Panels")]
    [SerializeField] private GameObject _creditsPanel;
    [SerializeField] private GameObject _optionPanel;

    [Header("Menu Buttons")]
    [SerializeField] private Button continueGameButton;
    [SerializeField] private Button loadGameButton;

    [Header("Clear Data Button")]
    [SerializeField] private Button clearButton;

    private void Start()
    {
        if (!DataPersistanceManager.instance.HasGameData())
        {
            continueGameButton.interactable=false;
        }
    }

    private void DisableButtonDependingOnData()
    {
        if (!DataPersistanceManager.instance.HasGameData())
        {
            continueGameButton.interactable = false;
            loadGameButton.interactable = false;
        }
    }

    public void OnNewGame()
    {
        //create a new game - which will intiialize game data
        DataPersistanceManager.instance.NewGame();

        //load the gameplay scene - which will in turn save the game because of
        //OnSceneUnloaded in the DataPersistanceManager
        SceneManager.LoadSceneAsync("Tutorial");
    }

    public void OnContinueGame()
    {
        //save the game anytime before loading a new scene
        DataPersistanceManager.instance.SaveGame();

        //load the next scene - which will in turn load the game because of
        //OnSceneLoaded in the DataPersistanceManager
        SceneManager.LoadSceneAsync("Ethan");
    }

    //public void OnClearGame(SaveSlot saveSlot)
    //{
    //    DataPersistanceManager.instance.DeleteProfileData(saveSlot.GetProfiled());
    //}

    #region ChangeScene
    public void ChangeScene(int sceneID)
    {
            SceneManager.LoadScene(sceneID);
    }
    #endregion

    #region Canvas Activations/Deactivation
    public void OpenOptionPanel()
    {
        _optionPanel.SetActive(true);
    }

    public void CloseOptionPanel()
    {
        _optionPanel.SetActive(false);
    }

    public void OpenCreditsPanel()
    {
        _creditsPanel.SetActive(true);
    }

    public void CloseCreditsPanel()
    {
        _creditsPanel.SetActive(false);
    }
    #endregion
    #region Quit Function
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
    #endregion
}
