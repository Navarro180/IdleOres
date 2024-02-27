using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileDisperse : MonoBehaviour
{
    public GameObject tile;

    public void OnCollisionEnter(Collision collision)
    {
            tileDisappear();
    }
    public void tileDisappear()
    {
        tile.SetActive(false);
    }
}
