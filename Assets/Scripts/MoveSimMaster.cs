using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSimMaster : MonoBehaviour
{
    public PlayerController playerRef;

    public Vector3 currentPos;

    // Start is called before the first frame update
    void Start()
    {
        playerRef = FindAnyObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newX = transform.position.x - (playerRef.currentHorizontalSpeed * Time.deltaTime);
        transform.position = new Vector3(newX, 0, 15);

    }
}
