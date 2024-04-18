using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Back_Up : MonoBehaviour
{
    GameObject boundary;
    private Vector3 startPosition;
    Vector3 moveVector = Vector3.right;
    private Rigidbody rigidBody;
    public float speed = 5;

    public void Start()
    {
        startPosition = transform.position;
        rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Move(moveVector);
        rigidBody = GetComponent<Rigidbody>();
    }

    //ball moves up and down
    private void Move(Vector3 moveDirection)
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "boundary")
        {
            Debug.Log("player hit boundary");
            moveVector = Vector3.left;
        }
    }
   
}
