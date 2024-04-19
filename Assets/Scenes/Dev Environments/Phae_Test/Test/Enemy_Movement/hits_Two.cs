using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hits_Two : MonoBehaviour
{
   public bool firstHit;
   public bool secondHit;
   public int hits = 25;


    public void Update()
    {
        getRidOf();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "boundary")
        {
            Debug.Log("boundary");

            firstHit = false;
            --hits;
        }
        if (collision.gameObject.tag == "boundary" && firstHit == false && hits <= 5)
        {
            Debug.Log("boundary");

            secondHit = false;
            --hits;
        }
    }

    public void getRidOf()
    {
        if (secondHit == false && firstHit == false && hits <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
