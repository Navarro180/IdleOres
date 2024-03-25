using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform moveParent;

    public GameObject[] prefabs;

    public float minSpawnTime = 0.0000000001f;
    public float maxSpawnTime = 0.0000001f;

    void Start()
    {
        // Start the spawning process
        InvokeRepeating("SpawnPrefab", 0f, 0.5f);
    }

    private void FixedUpdate()
    {
        moveParent = FindAnyObjectByType<MoveSimMaster>().transform;
    }

    void SpawnPrefab()
    {
        // Choose a random prefab from the array
        GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Length - 1)];

        // Generate a random Y position within a specified range
        float randomY = Random.Range(-19f, 0f);

        // Instantiate the prefab at the random position
        Instantiate(randomPrefab, new Vector3(10, randomY, 15), randomPrefab.transform.rotation, moveParent);
        
    }
}
