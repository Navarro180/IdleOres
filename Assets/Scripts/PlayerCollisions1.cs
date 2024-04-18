using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisions1 : MonoBehaviour, IDataPersistance
{
    public TextMeshProUGUI relicCounter;
    public int relicCount;

    private PlayerHealth pH;

    private void Start()
    {
        relicCount = 0;
        relicCounter.text = "Relics: " + relicCount;

        pH = GetComponent<PlayerHealth>();
    }
    #region Collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            Destroy(other.gameObject);
            DevRelicCountSubtract();
            //need to fix
            pH.Dmg(10);
        }
        else if (other.tag == "BugRelic")
        {
            Destroy(other.gameObject);
            relicCount++;
            relicCounter.text = "Relics: " + relicCount;
        }
        //change to collatables
        else if (other.tag == "SmallRock")
        {
            Destroy(other.gameObject);
            //DevRelicCountSubtract();
        }
        else if (other.tag == "LargeRock")
        {
            Destroy(other.gameObject);
            //DevRelicCountSubtract();
        }
        return;
    }
    #endregion

    public void DevRelicCountSubtract()
    {
        relicCount--;
        if (relicCount < 0)
        {
            relicCount = 0;
        }
        relicCounter.text = "Relics: " + relicCount;
    }

    #region Save/Load
    public void LoadData(GameData data)
    {
        foreach (KeyValuePair<string, bool> pair in data.relicCollected)
        {
            if (pair.Value)
            {
                relicCount++;
            }
        }
    }

    public void SaveData(ref GameData data)
    {
        //no data needs to be saved for this script?
    }
    #endregion
}
