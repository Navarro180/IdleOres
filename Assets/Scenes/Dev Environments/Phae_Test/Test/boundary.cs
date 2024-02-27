using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour
{
    public GameObject player;
    public GameObject bound;
    bool playerDrillUpdate_01;

    public void Start()
    {
        playerDrillUpdate_01 = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player" && playerDrillUpdate_01 == false)
        {
            //not pass
        }
        else
        {
            playerDrillUpdate_01 = true;
        }
    }

    public void outofBounds()
    {
        bound.SetActive(false);
    }
}
