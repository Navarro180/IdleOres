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
    public GameObject _infoPanel;

    [Header("Shop Pages")]
    public GameObject shopPage1;
    public GameObject shopPage2;
    public GameObject shopPage3;
    public GameObject shopPage4;

    public GameObject shopButton1R;
    public GameObject shopButton2L;
    public GameObject shopButton2R;
    public GameObject shopButton3L;
    public GameObject shopButton3R;
    public GameObject shopButton4L;
    //public GameObject shopButton4R;

    public GameObject pageLeftEnd;
    public GameObject pageRightEnd;

    [Header("Misc.")]
    public GameObject _HungryBoySetup;
    public GameObject mainRenderImage; 
    public GameObject mainUI;

    #region ChangeScene
    public void ReturnMainMenu(int sceneID)
    {
        _pausePanel.SetActive(false);
        SceneManager.LoadScene(sceneID);
    }
#endregion

    #region Canvas Activations/Deactivation
    public void OpenPausePanel()
    {
        _pausePanel.SetActive(true);
        mainRenderImage.SetActive(false);
        mainUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void ClosePausePanel()
    {
        _pausePanel.SetActive(false);
        mainRenderImage.SetActive(true);
        mainUI.SetActive(true);
        Time.timeScale = 1;
    }
    
    public void OpenOptionPanel()
    {
        _optionPanel.SetActive(true);
        _pausePanel.SetActive(false);
        mainRenderImage.SetActive(false);
        mainUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void CloseOptionPanel()
    {
        _optionPanel.SetActive(false);
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void OpenShopPanel()
    {
        _shopPanel.SetActive(true);
        _sellPanel.SetActive(false);
        mainRenderImage.SetActive(false);
        mainUI.SetActive(false);
        ShopPage1();
        Time.timeScale = 0;
    }

    public void ShopPage1() 
    {
        Debug.Log("Sent to Page 1");
        shopPage1.SetActive(true);
        shopPage2.SetActive(false);
        shopPage3.SetActive(false);
        shopPage4.SetActive(false);
        // Buttons
        pageLeftEnd.SetActive(true);
        shopButton1R.SetActive(true);
        shopButton2L.SetActive(false);
        shopButton2R.SetActive(false);
        pageRightEnd.SetActive(false);
    }

    public void ShopPage2()
    {
        Debug.Log("Sent to Page 2");
        shopPage1.SetActive(false);
        shopPage2.SetActive(true);
        shopPage3.SetActive(false);
        shopPage4.SetActive(false);
        // Buttons
        pageLeftEnd.SetActive(false);
        shopButton1R.SetActive(false);
        shopButton2L.SetActive(true);
        shopButton2R.SetActive(true);
        shopButton3L.SetActive(false);
        shopButton3R.SetActive(false);

    }

    public void ShopPage3()
    {
        Debug.Log("Sent to Page 3");
        shopPage1.SetActive(false);
        shopPage2.SetActive(false);
        shopPage3.SetActive(true);
        shopPage4.SetActive(false);
        // Buttons
        shopButton2L.SetActive(false);
        shopButton2R.SetActive(false);
        shopButton3L.SetActive(true);
        shopButton3R.SetActive(true);
        shopButton4L.SetActive(false);
        //shopButton4R.SetActive(false);
        pageRightEnd.SetActive(false);
    }

    public void ShopPage4()
    {
        Debug.Log("Sent to Page 4");
        shopPage1.SetActive(false);
        shopPage2.SetActive(false);
        shopPage3.SetActive(false);
        shopPage4.SetActive(true);
        // Buttons
        shopButton3L.SetActive(false);
        shopButton3R.SetActive(false);
        shopButton4L.SetActive(true);
        //shopButton4R.SetActive(true);
        pageRightEnd.SetActive(true);
    }

    public void CloseShopPanel()
    {
        _shopPanel.SetActive(false);
        mainRenderImage.SetActive(true);
        mainUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void OpenSellPanel()
    {
        _sellPanel.SetActive(true);
        _shopPanel.SetActive(false);
        mainRenderImage.SetActive(false);
        mainUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void CloseSellPanel()
    {
        _sellPanel.SetActive(false);
        mainRenderImage.SetActive(true);
        mainUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void OpenInfoPanel()
    {
        _infoPanel.SetActive(true);
        _pausePanel.SetActive(false);
        mainRenderImage.SetActive(false);
        mainUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void CloseInfoPanel()
    {
        _infoPanel.SetActive(false);
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    // HungryBoy
    public void OpenHungryBoy()
    {
        _HungryBoySetup.SetActive(true);
    }

    public void CloseHungryBoy()
    {
        _HungryBoySetup.SetActive(false);
    }
    #endregion
}
