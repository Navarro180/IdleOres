using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{

    [Header("Prefabs/Components")]
    public List<GameObject> possibleitemsSpawn = new List<GameObject>();
    public List<int> possibleInt = new List<int>();

    public float timeToDrop;
    private float currentTimeDrop;

    public bool isTimed;
    public bool isRandom;

    public void Start()
    {
        spawnDammit();
    }

    public void spawnDammit()
    {
        if (isTimed)
        {
            clockDoit();
        }
    }

    //creates a timer for a power drop
    private void clockDoit()
    {
        int index = isRandom ? Random.Range(0, possibleInt.Count) : 0;
        if (currentTimeDrop > 0)
        {
            currentTimeDrop -= Time.deltaTime;
        }
        else
        {
            spawnPower();
            currentTimeDrop = timeToDrop;
        }
    }

    //creates a random drop
    public void spawnPower()
    {
        int index = isRandom ? Random.Range(0, possibleitemsSpawn.Count) : 0;
        if (possibleitemsSpawn.Count > 0)
        {
            Instantiate(possibleitemsSpawn[index], transform.position, transform.rotation);
            transform.position += Vector3.down * Time.deltaTime;
        }
    }
}
