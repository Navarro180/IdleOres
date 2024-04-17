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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            Destroy(other.gameObject);

        }
        else if (other.tag == "BugRelic")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 25;
        }
        else if (other.tag == "SmallRock")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 2;
        }
        else if (other.tag == "LargeRock")
        {
            Destroy(other.gameObject);
            playerRef.currentOreValue += 4;
        }
        return;
    }
}
