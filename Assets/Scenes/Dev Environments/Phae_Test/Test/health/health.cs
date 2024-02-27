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

        if (collision.gameObject.tag == "boundary")
        {
            _health--;
        }

        if (collision.gameObject.tag == "enemy")
        {
            _health--;
        }
    }

 
}
