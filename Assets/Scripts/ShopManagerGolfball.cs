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
    // Page 1
    public TextMeshProUGUI currentMaxHorizontalSpeed;
    public TextMeshProUGUI currentAcceleration;
    public TextMeshProUGUI currentVerticalSpeed;
    public TextMeshProUGUI currentArmorHealth;
    // Page 2
    public TextMeshProUGUI currentDecreaseMines;
    public TextMeshProUGUI currentDecreaseRocks;

    [Header("==== Upgrade Costs ====")]
    // Page 1
    public long costMaxHorizontalSpeed = 400;
    public long costAcceleration = 500;
    public long costVerticalSpeed = 500;
    public long costArmorHealth = 1000;
    // Page 2
    public long costDecreaseMines = 10000;
    public long costIncreaseOre1 = 1000;
    public long costIncreaseOre2 = 1000;
    public long costIncreaseOre3 = 1000;
    // Page 3
    public long costIncreaseOre4 = 1000;
    public long costIncreaseOre5 = 1000;
    public long costIncreaseOre6 = 1000;
    public long costIncreaseOre7 = 1000;
    // Page 4
    public long costIncreaseOre8 = 1000;
    public long costIncreaseOre9 = 1000;
    public long costIncreaseBones = 1000;
    public long costIncreaseBugRelic = 1000;

    [Header("==== Upgrade Cost Readouts ====")]
    public TextMeshProUGUI costUpgradeAcceleration;
    public TextMeshProUGUI costUpgradeMaxHorizontalSpeed;
    public TextMeshProUGUI costUpgradeVerticalSpeed;
    public TextMeshProUGUI costUpgradeArmorHealth;
    public TextMeshProUGUI costUpgradeNewDepth;

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
