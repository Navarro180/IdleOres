using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;

public class IdleManager : MonoBehaviour
{
    // Very special thanks to Els Fouche for help with planning out this script! -Ethan 

    // Reference Variables
    public GameObject shopManagerRef;
    public GameObject playerRef;
    
    // List of ore values
    public List<long> oreValues = new List<long>();

    // Ore & Value Variables
    public long localOreValue;
    public float oreAvg;
    public int localMaxOreLevel;
    
    // Time Variables
    public DateTime dateTimeNow;

    // Update is called once per frame
    private void Update()
    {
        GetOreAverage();
        
        localMaxOreLevel = shopManagerRef.GetComponent<ShopManagerGolfball>().oreSpawnIndexMaximum;
        localOreValue = playerRef.GetComponent<PlayerController>().currentOreValue;
    }

    public float GetOreAverage()
    {
        
        for (int i = 0; i < localMaxOreLevel; i++)
        {

        }
        return oreAvg;
    }

    /// <summary>
    /// Call this whenever the game is started. 
    /// </summary>
    private void IdleOreGained()
    {
        // storedOreValue += (TimeSinceLastUpdate() * storedTopSpeedValue * AverageValueOfUnlockedOres())
    }

    private long AverageValueOfUnlockedOres()
    {
        long tempOreValue = 0;
        for (int i = 0; i <= localMaxOreLevel; i++)
        {
            tempOreValue += oreValues[i];
        }
        return tempOreValue / localMaxOreLevel;
    }



    /// <summary>
    /// THIS IS AN EXAMPLE OF WHAT NEEDS TO BE SAVED IN THE SAVE SYSTEM
    /// </summary>
    private void UpdateTime()
    {
        dateTimeNow = DateTime.Now; // Store the current time. 
    }

    /// <summary>
    /// This returns the time elapsed in seconds since
    /// the last time it was called. It needs to be called by something
    /// like the IdleMoneyGained function below at game start
    /// before the autosave feature overwrites the previous time stored
    /// in dateTime. 
    /// </summary>
    private int TimeSinceLastUpdate()
    {
        TimeSpan timeElapsed = DateTime.Now - dateTimeNow;

        return (int)timeElapsed.TotalSeconds;
    }
}