using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerController playerRef;

    private void Start()
    {
        
    }
    #region Collider
    private void OnTriggerEnter(Collider other)
    {
        //this is located on the player health
        //if (other.tag == "Mine")
        //{
        //    Destroy(other.gameObject);

        //}
        if (other.tag == "BugRelic")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 25;
        }
        else if (other.tag == "SmallRock")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 1;
        }
        else if (other.tag == "LargeRock")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 2;
        }
        return;
    }
    #endregion

    //#region Save/Load
    //public void LoadData(GameData data)
    //{
    //    foreach (KeyValuePair<string, bool> pair in data.relicCollected)
    //    {
    //        if (pair.Value)
    //        {
    //            //relicCount++;
    //        }
    //    }
    //}

    //public void SaveData(ref GameData data)
    //{
    //    //no data needs to be saved for this script?
    //}
    //#endregion
}
