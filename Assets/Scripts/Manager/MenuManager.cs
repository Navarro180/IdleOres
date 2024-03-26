using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject _levelPanel;
    public GameObject _optionPanel;

    #region Pause/Unpause

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
    }

    public void CloseOptionPanel()
    {
        _optionPanel.SetActive(false);
    } 
    
    public void ClosePanel()
    {
        _levelPanel.SetActive(false);
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
