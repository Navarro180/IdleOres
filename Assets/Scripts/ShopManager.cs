using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopOverlayRef;
    public GameObject sellOverlayRef;
    public GameObject optionOverlayRef;
    public GameObject settingMenuOverlayRef;
    public GameObject infoOverlayRef;

    [Header("==== Current Upgrade Values ====")]
    public TextMeshProUGUI currentUpgradeValueAcceleration;
    public TextMeshProUGUI currentUpgradeValueMaxHorizontalSpeed;
    public TextMeshProUGUI currentUpgradeValueVerticalSpeed;
    public TextMeshProUGUI currentUpgradeValueArmorHealth;
    public TextMeshProUGUI currentUpgradeValueDepth;

    [Header("==== Upgrade Costs ====")]
    public TextMeshProUGUI costUpgradeAcceleration;
    public TextMeshProUGUI costUpgradeMaxHorizontalSpeed;
    public TextMeshProUGUI costUpgradeVerticalSpeed;
    public TextMeshProUGUI costUpgradeArmorHealth;
    public TextMeshProUGUI costUpgradeNewDepth;

    // SHOP - ENTER / EXIT

    public void ButtonShopEnter()
    {
        sellOverlayRef.SetActive(false);
        shopOverlayRef.SetActive(true);
        Time.timeScale = 0;
    }


    // SELL - ENTER / EXIT
    public void ButtonSellEnter()
    {
        sellOverlayRef.SetActive(true);
        shopOverlayRef.SetActive(false);
        Time.timeScale = 0;
    }

    public void ButtonOverlayExit()
    {
        sellOverlayRef.SetActive(false);
        shopOverlayRef.SetActive(false);
        optionOverlayRef.SetActive(false);
        settingMenuOverlayRef.SetActive(false);
        infoOverlayRef.SetActive(false);

        Time.timeScale = 1;
    }

    // UPGRADES
    public void ButtonUpgradeMaxHorizontalSpeed() 
    {
        
    }

    public void ButtonUpgradeAcceleration()
    {

    }

    public void ButtonUpgradeVerticalSpeed()
    {

    }

    public void ButtonUpgradeArmorHealth() 
    {

    }

    public void ButtonUpgradeNewDepth() 
    {
        
    }
}
