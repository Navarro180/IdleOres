using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject _levelPanel;
    public GameObject _optionPanel;

#region New/Load Game
    public void NewGame()
    {
        DataPersistanceManager.instance.NewGame();
    }

    public void LoadGame()
    {
        DataPersistanceManager.instance.LoadGame();
    }
#endregion

#region ChangeScene
    public void ReturnMainMenu(int sceneID)
    {
            SceneManager.LoadScene(sceneID);
    }
#endregion

#region Canvas Activations/Deactivation
    public void OpenOptionPanel()
    {
        _optionPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseOptionPanel()
    {
        _optionPanel.SetActive(false);
        Time.timeScale = 0;
    } 
    
    public void ClosePanel()
    {
        _levelPanel.SetActive(false);
        Time.timeScale = 0;
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
