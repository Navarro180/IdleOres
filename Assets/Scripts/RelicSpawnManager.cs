using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicSpawnManager : MonoBehaviour
{
    public GameObject[] relics;

    public float minSpawnTime = 0.0000000001f;
    public float maxSpawnTime = 0.0000001f;

    void Start()
    {
        // Start the spawning process
        InvokeRepeating("SpawnPrefab", 0f, 5f);
    }

    void SpawnPrefab()
    {
        // Choose a random prefab from the array
        GameObject randomPrefab = relics[Random.Range(0, relics.Length)];

        // Generate a random Y position within a specified range
        float randomY = Random.Range(-19f, -5f);

        // Instantiate the prefab at the random position
        Instantiate(randomPrefab, new Vector3(0, randomY, 15), randomPrefab.transform.rotation);
    }
}
