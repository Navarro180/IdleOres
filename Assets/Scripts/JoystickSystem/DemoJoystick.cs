using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class DemoJoystick : MonoBehaviour
{
    private InputManager01 input;
    private Rigidbody2D rb;

    public float speed;

    UnityEngine.Vector2 movDir;
    bool isMoving;

    private void Awake()
    {
        input = GetComponent<InputManager01>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movDir = input.MoveInput.normalized;

        isMoving = Convert.ToBoolean(movDir.magnitude);

        //it will only change dir without moving
        Rotate();
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            rb.MovePosition(rb.position + movDir * speed * Time.fixedDeltaTime);
        }
    }
    private void Rotate()
    {
        if (isMoving)
        {
            float angle = Mathf.Atan2(movDir.y, movDir.x) * Mathf.Rad2Deg - 90f;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}