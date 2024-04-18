using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oil_Leak : MonoBehaviour
{
    public float loseOilTimer;

    public int _health;

    GameObject oilSpill;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision Happening");
        if (collision.gameObject.tag == "Health Pack")
        {
            _health++;
        }

        if (collision.gameObject.tag == "boundary")
        {
            _health--;
            Debug.Log("collision Happening 01");
            if (oilSpill == false)
            {
                StartCoroutine(leaking());
            }
        }

        if (collision.gameObject.tag == "enemy")
        {
            _health--;
            StartCoroutine(leaking());
        }
    }

    //player vehicle lose health
    public IEnumerator leaking()
    {
        for (int index = 0; index < 30; index++)
        {
            if (index % 2 == 0)
            {
                gameObject.GetComponent<ParticleSystem>().enableEmission = true;
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().enableEmission = false;
            }
            yield return new WaitForSeconds(.1f);
        }
        gameObject.GetComponent<ParticleSystem>().enableEmission = false;
    }
}
