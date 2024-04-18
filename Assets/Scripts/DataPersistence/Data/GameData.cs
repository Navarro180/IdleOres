using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    //track the player actions
    public int playerHealth;
    public Vector3 playerPos;

    //collectables
    //public Dictionary<string, bool> relicCollected;
    public SerializableDictionary<string, bool> relicCollected;

    //the value defined in this constructor will be default values
    //the game starts with when there's no data to load

    public GameData()
    {
        this.playerHealth = 100;
        playerPos = Vector3.zero;
        //relicCollected = new Dictionary<string, bool>();
        relicCollected = new SerializableDictionary<string, bool>();
    }
}
