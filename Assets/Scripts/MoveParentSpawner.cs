using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParentSpawner : MonoBehaviour
{
    public GameObject levelSimPrefab;
    public Transform spawnPosTransform;

    private void Start()
    {
        spawnPosTransform = this.transform;
        CreateSimParent();
    }

    public void CreateSimParent()
    {
        Instantiate(levelSimPrefab, spawnPosTransform);

    }
}
