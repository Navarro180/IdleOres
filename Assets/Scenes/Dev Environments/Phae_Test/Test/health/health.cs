using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int _health;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Health Pack")
        {
            _health++;
        }

        if (collision.gameObject.tag == "SmallRock")
        {
            _health--;
        }

        if (collision.gameObject.tag == "LargeRock")
        {
            _health--;
            _health--;
        }

        if (collision.gameObject.tag == "Mine")
        {
            _health--;
            _health--;
            _health--;
        }
    }

 
}
