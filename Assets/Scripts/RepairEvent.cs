using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RepairEvent : MonoBehaviour
{
    //public GameObject repairOverlay;
    public GameManager gameManager;
    public PlayerBehaviour playerBehaviour;
    //HealthBar healthBar;
    public TextMeshProUGUI gameScreenArmorHealthText;

    // Start is called before the first frame update
    void Start()
    {
        //repairOverlay.SetActive(false);
        //repairOverlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //int tempHealth = gameManager.GetComponent<GameManager>().currentHealth;      // TODO: This isn't reading correctly for some reason. Good luck!
        //if (tempHealth <= 25)
        //{
        //    repairOverlay.SetActive(true);
        //    RepairHealth(20);
        //    gameScreenArmorHealthText.text = gameManager.currentHealth.ToString();
        //}
        //return;
        RepairHealth(10);
    }

    public void RepairHealth(int healing)
    {
        //playerBehaviour.PlayerHeal(20);
        //GameManager.gameManager._playerHealth.HealUnit(healing);
        //healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }

    public void ButtonRepair()
    {

    }
}
