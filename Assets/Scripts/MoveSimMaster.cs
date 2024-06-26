using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSimMaster : MonoBehaviour
{
    public GameObject playerRef;
    public MoveParentSpawner moveParentSpawnerRef;
    public ShopManagerGolfball shopManagerRef;

    // Child Spawning Variables
    public GameObject[] prefabs;
    public int maxChildrenSpawned = 3;

    // ADD NEW ORE BUTTON VARIABLES
    public int localOreSpawnIndexMaximum;

    // SPAWN REGION VARIABLES
    public float spawnOriginX = 25f;
    public float xPosRange = 25f;
    public float spawnYMin = 5f;
    public float spawnYMax = -30;
    public float zPos = 15f;

    private void Awake()
    {
        playerRef = PlayerController.instance.gameObject;
        moveParentSpawnerRef = FindAnyObjectByType<MoveParentSpawner>();
        shopManagerRef = FindAnyObjectByType<ShopManagerGolfball>();
        localOreSpawnIndexMaximum = shopManagerRef.GetComponent<ShopManagerGolfball>().oreSpawnIndexMaximum;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawn Logic
        for (int i = 0; i < maxChildrenSpawned; i++)
        {
            GameObject randomPrefab = prefabs[Random.Range(0, localOreSpawnIndexMaximum)];
            float randomY = Random.Range(spawnYMin, spawnYMax);
            float randomX = Random.Range(spawnOriginX - xPosRange, spawnOriginX + xPosRange);
            Instantiate(randomPrefab, new Vector3(randomX, randomY, zPos), randomPrefab.transform.rotation, this.transform);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newX = transform.position.x - (playerRef.GetComponent<PlayerController>().currentHorizontalSpeed * Time.deltaTime); // TODO FIX
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
