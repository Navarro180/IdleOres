using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    //track the player actions
    public long lastUpdated;
    public int playerHealth;
    public int moneyText;
    public int valueText;
   

    //collectables
    //public Dictionary<string, bool> relicCollected;
    //public SerializableDictionary<string, bool> relicCollected;

    //the value defined in this constructor will be default values
    //the game starts with when there's no data to load

    public GameData()
    {
        this.playerHealth = 0;
        this.moneyText = 0;
        this.valueText = 0;
        
        //relicCollected = new Dictionary<string, bool>();
        //relicCollected = new SerializableDictionary<string, bool>();
    }
}
