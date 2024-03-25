using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MoveSimMaster")
        {
            other.transform.position = new Vector3(0, 0, 15);
        }
        else
        {
            Destroy(other.gameObject);
        }
        return;
    }
}
