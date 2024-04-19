using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSimMaster : MonoBehaviour
{
    public PlayerController playerRef;
    public MoveParentSpawner moveParentSpawnerRef;

    // Child Spawning Variables
    public GameObject[] prefabs;
    public int maxChildrenSpawned = 3;

    public float spawnOriginX = 25f;
    public float xPosRange = 25f;
    public float spawnYMin = 5f;
    public float spawnYMax = -30;
    public float zPos = 15f;

    private void Awake()
    {
        playerRef = FindAnyObjectByType<PlayerController>();
        moveParentSpawnerRef = FindAnyObjectByType<MoveParentSpawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawn Logic
        for (int i = 0; i < maxChildrenSpawned; i++)
        {
            GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Length - 1)];
            float randomY = Random.Range(spawnYMin, spawnYMax);
            float randomX = Random.Range(spawnOriginX - xPosRange, spawnOriginX + xPosRange);
            Instantiate(randomPrefab, new Vector3(randomX, randomY, zPos), randomPrefab.transform.rotation, this.transform);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newX = transform.position.x - (playerRef.currentHorizontalSpeed * Time.deltaTime);
        transform.position = new Vector3(newX, 0, 15);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MoveSimSpawnTrigger")
        {
            moveParentSpawnerRef.CreateSimParent();
        }
    }
}
