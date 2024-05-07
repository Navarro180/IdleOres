using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject _creditsPanel;
    public GameObject _optionPanel;

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

    public void OpenCreditPanel()
    {
        _creditsPanel.SetActive(true);
    }
    
    public void CloseCreditPanel()
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
