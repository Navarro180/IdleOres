using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_Move_Enemy : MonoBehaviour
{
    public PlayerController anotherplayerRef;
    public MoveParentSpawner moveSpawnerRefTwo;

    public GameObject[] prefabsTwo;
    public int maxEnemiesSpawned = 10;

    public float spawnOriginX_Same = 25f;
    public float xPosRange_Same = 25f;
    public float spawnYMin_Same = 5f;
    public float spawnYMax_Same = -30;
    public float zPos_Same = 15f;

    private void Awake()
    {
        anotherplayerRef = FindAnyObjectByType<PlayerController>();
        moveSpawnerRefTwo = FindAnyObjectByType<MoveParentSpawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxEnemiesSpawned; i++)
        {
            GameObject randomPrefab = prefabsTwo[Random.Range(0, prefabsTwo.Length - 1)];
            float randomY = Random.Range(spawnYMin_Same, spawnYMax_Same);
            float randomX = Random.Range(spawnOriginX_Same - xPosRange_Same, spawnOriginX_Same + xPosRange_Same);
            Instantiate(randomPrefab, new Vector3(randomX, randomY, zPos_Same), randomPrefab.transform.rotation, this.transform);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newX = transform.position.x - (anotherplayerRef.currentHorizontalSpeed * Time.deltaTime);
        transform.position = new Vector3(newX, 0, 15);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MoveSimSpawnTrigger")
        {
            moveSpawnerRefTwo.CreateSimParent();
        }
    }
}

