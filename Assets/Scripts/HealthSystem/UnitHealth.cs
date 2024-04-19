using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth 
{
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
}
