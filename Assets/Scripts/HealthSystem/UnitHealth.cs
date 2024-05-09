using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnitHealth
{
    //you can change any health method in this class

    //public TextMeshProUGUI gameScreenArmorHealthText;
    //GameManager gameManager;

    //Fields
    int health;
    int maxHealth;

    //Properties
    public int Health { get { return health; } set { health = value; } }
    public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

    //Constructor
    public UnitHealth(int h, int mH)
    {
        health = h;
        maxHealth = mH;
    }

    //Methods
    public void DmgUnit(int dmgA)
    {
        if (health > 0)
        {
            health -= dmgA;
        }
    }

    public void HealUnit(int healA)
    {
        if (health < maxHealth)
        {
            health += healA;
        }
        if (health > maxHealth)
        {
            health = maxHealth;

        }
    }

    //public void LoadData(GameData data)
    //{
    //    this.health = data.playerHealth;
    //}

    //public void SaveData(ref GameData data)
    //{
    //    data.playerHealth = this.health;
    //}
}
