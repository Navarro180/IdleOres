using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSimStatic : MonoBehaviour
{
    public PlayerController playerControllerRef;

    public float entitySpeedMod = 2.4f;

    private void Start()
    {
        playerControllerRef = FindAnyObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + ((playerControllerRef.currentHorizontalSpeed * Time.deltaTime) * -playerControllerRef.speedMod) * entitySpeedMod, transform.position.y, transform.position.z);
    }
}
