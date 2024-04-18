using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialDrop : MonoBehaviour
{
    [Header("Prefabs/Components")]
    public List<GameObject> possibleitemsSpawn = new List<GameObject>();
    public List<int> possibleInt = new List<int>();

    public bool isRandom;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int index = isRandom ? Random.Range(0, possibleitemsSpawn.Count) : 0;
            if (possibleitemsSpawn.Count > 0)
            {
                Instantiate(possibleitemsSpawn[index], transform.position, transform.rotation);
                transform.position += Vector3.down * Time.deltaTime;
            }

            Destroy(this.gameObject);
        }
    }
}
