using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test_Shop_Inventory : MonoBehaviour
{
    public int Ores;
    public int Health;

    public Image healthBar;

    public TextMeshProUGUI Ores_text;
    public TextMeshProUGUI Health_text;


    private void Start()
    {
        Ores = PlayerPrefs.GetInt("Ores");
        Health = PlayerPrefs.GetInt("Health");

        Ores = 2000;
        Ores_text.text = Ores.ToString();
        Health = 100;
        Health_text.text = Health.ToString();
    }

    public void Update()
    {
        if (Health <= 0)
        {
            //whatever you want to happen here
        }
    }

    public void BuyHealth()
    {
        if (Ores >= 200)
        {
            Ores -= 200;
            Ores_text.text = Ores.ToString();

            Health += 1;
            Health_text.text = Health.ToString();

            PlayerPrefs.SetInt("Ores", Ores);
            PlayerPrefs.SetInt("Health", Health);
        }
        else
        {
            print("Not Enough Coins");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Health Pack")
        {
            Heal(5);
        }

        if (collision.gameObject.tag == "SmallRock")
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {

        Health -= damage;
        healthBar.fillAmount = Health / 100;

    }

    public void Heal(int Health)
    {
        Health += Health;
        Health = Mathf.Clamp(Health, 0, 100);

        healthBar.fillAmount = Health / 100;
    }
}
