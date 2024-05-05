using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManagerGolfball : MonoBehaviour
{
    // ^^^^ Same issue as MainMenuGolfball..  >:')
    // Refer to said script for explanation. Thank you. -Ethan :)

    public PlayerController playerController;
    public UnitHealth unitHealth;
    public GameManager gameManager;

    public TextMeshProUGUI gameScreenArmorHealthText;

    public float finalHorizontalSpeedUpgrade = 200f;
    public float finalVerticalSpeedUpgrade = 150f;
    public float finalAccelerationUpgrade = 150f;


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
    public int costMaxHorizontalSpeed = 10000;
    public int costAcceleration = 8000;
    public int costVerticalSpeed = 8000;
    public int costArmorHealth = 9000;
    [Header("Page 2")]
    public int costDecreaseRocks = 30000;
    public int costDecreaseMines = 30000;
    public int costIncreaseOre1 = 10000;
    public int costIncreaseOre2 = 20000;
    [Header("Page 3")]
    public int costIncreaseOre3 = 30000;
    public int costIncreaseOre4 = 50000;
    public int costIncreaseOre5 = 50000;
    public int costIncreaseOre6 = 50000;
    [Header("Page 4")]
    public int costIncreaseOre7 = 100000;
    public int costIncreaseOre8 = 100000;
    public int costIncreaseOre9 = 100000;
    public int costIncreaseBones = 1000000;

    [Header("==== Upgrade Cost Readouts ====")]
    [Header("Page 1")]
    public TextMeshProUGUI costTextMaxHorizontalSpeed;
    public TextMeshProUGUI costTextAcceleration;
    public TextMeshProUGUI costTextVerticalSpeed;
    public TextMeshProUGUI costTextArmorHealth;
    [Header("Page 2")]
    public TextMeshProUGUI costTextDecreaseRocks;
    public TextMeshProUGUI costTextDecreaseMines;
    public TextMeshProUGUI costTextIncreaseOre1;
    public TextMeshProUGUI costTextIncreaseOre2;
    [Header("Page 3")]
    public TextMeshProUGUI costTextIncreaseOre3;
    public TextMeshProUGUI costTextIncreaseOre4;
    public TextMeshProUGUI costTextIncreaseOre5;
    public TextMeshProUGUI costTextIncreaseOre6;
    [Header("Page 4")]
    public TextMeshProUGUI costTextIncreaseOre7;
    public TextMeshProUGUI costTextIncreaseOre8;
    public TextMeshProUGUI costTextIncreaseOre9;
    public TextMeshProUGUI costTextIncreaseBones;

    private void Update()
    {
        gameScreenArmorHealthText.text = GameManager.gameManager._playerHealth.Health.ToString();
    }

    // SHOP UPDATING
    public void UpdateReadouts()
    {
        // Page 1
        currentMaxHorizontalSpeed.text = playerController.upgradeMaxHorizontalSpeed.ToString();
        currentAcceleration.text = playerController.upgradeAcceleration.ToString();
        currentVerticalSpeed.text = playerController.upgradeMaxVerticalSpeed.ToString();
        currentArmorHealth.text = gameManager.currentHealth.ToString();
        // Page 2
        currentDecreaseRocks.text = 
        currentDecreaseMines.text = 
        currentIncreaseOre1.text = 
        currentIncreaseOre2.text = 
        // Page 3
        currentIncreaseOre3.text = 
        currentIncreaseOre4.text = 
        currentIncreaseOre5.text = 
        currentIncreaseOre6.text = 
        // Page 4
        currentIncreaseOre7.text = 
        currentIncreaseOre8.text = 
        currentIncreaseOre9.text = 
        currentIncreaseBones.text = currentIncreaseBones.ToString();
    }
    
    // UPGRADES
    // Page 1
    public void ButtonUpgradeMaxHorizontalSpeed() 
    {
        if (playerController.currentMoney >= costMaxHorizontalSpeed && playerController.upgradeMaxHorizontalSpeed < finalHorizontalSpeedUpgrade)
        {
            playerController.currentMoney -= costMaxHorizontalSpeed;
            playerController.upgradeMaxHorizontalSpeed += 4.0f;
            UpdateReadouts();
            return;
        }
        return;
    }

    public void ButtonUpgradeAcceleration()
    {
        if (playerController.currentMoney >= costAcceleration && playerController.upgradeAcceleration < finalAccelerationUpgrade)
        {
            playerController.currentMoney -= costAcceleration;
            playerController.upgradeAcceleration += 0.5f;
            UpdateReadouts();
            return;
        }
        return;
    }

    public void ButtonUpgradeVerticalSpeed()
    {
        if (playerController.currentMoney >= costVerticalSpeed && playerController.upgradeMaxVerticalSpeed <= finalVerticalSpeedUpgrade)
        {
            playerController.currentMoney -= costVerticalSpeed;
            playerController.upgradeMaxVerticalSpeed += 1.0f;
            UpdateReadouts();
            return;
        }
        return;
    }

    public void ButtonUpgradeArmorHealth() 
    {
        if (playerController.currentMoney >= costArmorHealth)
        {
            playerController.currentMoney -= costArmorHealth;
            gameManager.maxHealth += 100;
            gameManager.currentHealth = gameManager.maxHealth;
            UpdateReadouts();
            return;
        }
        return;
    }
    
}
