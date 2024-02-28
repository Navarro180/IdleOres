using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisions : MonoBehaviour
{
    public TextMeshProUGUI relicCounter;
    public int relicCount;

    private void Start()
    {
        relicCount = 0;
        relicCounter.text = "Relics: " + relicCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            Destroy(other.gameObject);
            DevRelicCountSubtract();
        }
        else if (other.tag == "BugRelic")
        {
            Destroy(other.gameObject);
            relicCount++;
            relicCounter.text = "Relics: " + relicCount;
        }
        else if (other.tag == "SmallRock")
        {
            Destroy(other.gameObject);
            DevRelicCountSubtract();
        }
        else if (other.tag == "LargeRock")
        {
            Destroy(other.gameObject);
            DevRelicCountSubtract();
        }
        return;
    }

    public void DevRelicCountSubtract()
    {
        relicCount--;
        if (relicCount < 0)
        {
            relicCount = 0;
        }
        relicCounter.text = "Relics: " + relicCount;
    }
}
