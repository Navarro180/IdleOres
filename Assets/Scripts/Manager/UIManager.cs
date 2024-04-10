using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject _optionPanel;
    public GameObject _shopPanel;
    public GameObject _sellPanel;
    public GameObject _pausePanel;

#region ChangeScene
    public void ReturnMainMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
#endregion

    #region Canvas Activations/Deactivation
    public void OpenPausePanel()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePausePanel()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void OpenOptionPanel()
    {
        _optionPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseOptionPanel()
    {
        _optionPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenShopPanel()
    {
        _shopPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseShopPanel()
    {
        _shopPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenSellPanel()
    {
        _sellPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSellPanel()
    {
        _sellPanel.SetActive(false);
        Time.timeScale = 1;
    }
    #endregion
}
