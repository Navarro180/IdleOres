using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManagerGolfball : MonoBehaviour
{
    // ^^^^ Same issue as MainMenuGolfball..  >:')
    // Refer to said script for explanation. Thank you. -Ethan :)

    // This all should've been done using scriptable objects, but difficulties in communication meant changes in priorities unfortunately.
    [Header("==== Current Upgrade Value Readouts ====")]
    [Header("Page 1")]
    public TextMeshProUGUI currentMaxHorizontalSpeed;
    public TextMeshProUGUI currentAcceleration;
    public TextMeshProUGUI currentVerticalSpeed;
    public TextMeshProUGUI currentArmorHealth;
    [Header("Page 2")]
    public TextMeshProUGUI currentDecreaseRocks;
    public TextMeshProUGUI currentDecreaseMines;
    public TextMeshProUGUI currentIncreaseOre1;
    public TextMeshProUGUI currentIncreaseOre2;
    [Header("Page 3")]
    public TextMeshProUGUI currentIncreaseOre3;
    public TextMeshProUGUI currentIncreaseOre4;
    public TextMeshProUGUI currentIncreaseOre5;
    public TextMeshProUGUI currentIncreaseOre6;
    [Header("Page 4")]
    public TextMeshProUGUI currentIncreaseOre7;
    public TextMeshProUGUI currentIncreaseOre8;
    public TextMeshProUGUI currentIncreaseOre9;
    public TextMeshProUGUI currentIncreaseBones;

    [Header("==== Upgrade Costs ====")]
    [Header("Page 1")]
    public long costMaxHorizontalSpeed = 10000;
    public long costAcceleration = 8000;
    public long costVerticalSpeed = 8000;
    public long costArmorHealth = 9000;
    [Header("Page 2")]
    public long costDecreaseRocks = 30000;
    public long costDecreaseMines = 30000;
    public long costIncreaseOre1 = 10000;
    public long costIncreaseOre2 = 20000;
    [Header("Page 3")]
    public long costIncreaseOre3 = 30000;
    public long costIncreaseOre4 = 50000;
    public long costIncreaseOre5 = 50000;
    public long costIncreaseOre6 = 50000;
    [Header("Page 4")]
    public long costIncreaseOre7 = 100000;
    public long costIncreaseOre8 = 100000;
    public long costIncreaseOre9 = 100000;
    public long costIncreaseBones = 1000000;

    [Header("==== Upgrade Cost Readouts ====")]
    [Header("Page 1")]
    public TextMeshProUGUI costTextMaxHorizontalSpeed;
    public TextMeshProUGUI costTextAcceleration;
    public TextMeshProUGUI costTextVerticalSpeed;
    public TextMeshProUGUI costTextArmorHealth;
    [Header("Page 1")]
    public TextMeshProUGUI costTextDecreaseRocks;
    public TextMeshProUGUI costTextDecreaseMines;
    public TextMeshProUGUI costTextIncreaseOre1;
    public TextMeshProUGUI costTextIncreaseOre2;
    [Header("Page 1")]
    public TextMeshProUGUI costTextIncreaseOre3;
    public TextMeshProUGUI costTextIncreaseOre4;
    public TextMeshProUGUI costTextIncreaseOre5;
    public TextMeshProUGUI costTextIncreaseOre6;
    [Header("Page ")]
    public TextMeshProUGUI costTextIncreaseOre7;
    public TextMeshProUGUI costTextIncreaseOre8;
    public TextMeshProUGUI costTextIncreaseOre9;
    public TextMeshProUGUI costTextIncreaseBones;

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
