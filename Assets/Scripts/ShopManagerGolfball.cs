using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManagerGolfball : MonoBehaviour
{
    // ^^^^ Same issue as MainMenuGolfball..  >:')
    // Refer to said script for explanation. Thank you. -Ethan :)

    public static ShopManagerGolfball Instance;

    public PlayerController playerController;
    public GameObject unitHealth;
    public GameManager gameManager;
    public GameObject moveSimLv1Ref;

    // FOR ADD NEW ORE SHOP BUTTON
    public int oreSpawnIndexMaximum = 45;

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
    public int costAcceleration = 5000;
    public int costVerticalSpeed = 8000;
    public int costArmorHealth = 9000;
    public int costNewOre = 15000;
    [Header("Page 2")]
    public int costDecreaseRocks = 30000;
    public int costDecreaseMines = 30000;
    public int costIncreaseOre1 = 5000;
    public int costIncreaseOre2 = 10000;
    [Header("Page 3")]
    public int costIncreaseOre3 = 30000;
    public int costIncreaseOre4 = 50000;
    public int costIncreaseOre5 = 50000;
    public int costIncreaseOre6 = 50000;
    [Header("Page 4")]
    public int costIncreaseOre7 = 100000;
    public int costIncreaseOre8 = 125000;
    public int costIncreaseOre9 = 150000;
    public int costIncreaseBones = 1000000;

    [Header("==== Upgrade Cost Readouts ====")]
    [Header("Page 1")]
    public TextMeshProUGUI costTextMaxHorizontalSpeed;
    public TextMeshProUGUI costTextAcceleration;
    public TextMeshProUGUI costTextVerticalSpeed;
    public TextMeshProUGUI costTextArmorHealth;
    public TextMeshProUGUI costAddNewOre;
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

    // TempValues
    public int currentRockCount;

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
        /*
        // Page 2
        currentDecreaseRocks.text = currentRockCount.ToString();
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
        */
    }
    /*
    // READOUT FUNCTIONS

    public void RocksReadoute()
    {
        foreach (var item in moveSimLv1Ref.GetComponent<MoveSimMaster>().prefabs)
        {
            if (item.tag == "SmallRock" || item.tag == "LargeRock")
            {
                currentRockCount++;
            }
            return;
        }
        UpdateReadouts();
    }

    */
    
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
        if (playerController.currentMoney >= costArmorHealth /*&& playerController.GetComponent<PlayerBehaviour>().mineDamage > 1*/)
        {
            playerController.currentMoney -= costArmorHealth;
            //unitHealth.GetComponent<UnitHealth>().maxHealth += 100;
            //unitHealth.GetComponent<UnitHealth>().health = unitHealth.GetComponent<UnitHealth>().maxHealth;
            //playerController.GetComponent<PlayerBehaviour>().mineDamage -= 1;

            UpdateReadouts();
            return;
        }
        return;
    }

    public void ButtonUpgradeAddNewOre()
    {
        if (playerController.currentMoney >= costNewOre && oreSpawnIndexMaximum < 80)
        {
            playerController.currentMoney -= costNewOre;
            //moveSimLv1Ref.GetComponent<MoveSimMaster>().oreSpawnIndexMaximum += 1;
            oreSpawnIndexMaximum++;
            UpdateReadouts();
            return;
        }
        return;
    }

    // Page 2 

    public void ButtonDecreaseRocks()
    {
        if (playerController.currentMoney >= costDecreaseRocks)
        {
            playerController.currentMoney -= costArmorHealth;
            
            UpdateReadouts();
            return;
        }
        return;
    }

    public void ButtonDecreaseMines()
    {
        if (playerController.currentMoney >= costDecreaseMines)
        {
            playerController.currentMoney -= costDecreaseMines;
            
            UpdateReadouts();
            return;
        }
        return;
    }
}
