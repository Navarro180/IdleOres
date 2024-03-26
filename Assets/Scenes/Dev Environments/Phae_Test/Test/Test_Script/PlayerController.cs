using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveInput;
    public GameObject shopRef;

    [Header("Vertical Data")]
    public float currentAngle = 0f;
    public float maxVerticalSpeed = 1.5f;
    public float topBarrier = 10.0f;

    [Header("Horizontal Data")]
    public float currentHorizontalSpeed = 0.7f;
    public float speedMod = 1.0f;
    public float minHorizontalSpeed = 0.5f;
    public float maxHorizontalSpeed = 3.0f;

    private void Update()
    {
        Move();
        Boost();
    }

    private void Move()
    {
        moveInput = UserInput.instance.MoveInput.y;
        UpdatePosition();
        UpdateRotation();
        AngleLimitSnap();
    }
    private void Boost()
    {
        moveInput = UserInput.instance.MoveInput.x;
        UpdateSpeed();
    }

    public void UpdateSpeed()
    {
        if (moveInput != 0)
        {
            currentHorizontalSpeed += moveInput * speedMod * Time.deltaTime;
            currentHorizontalSpeed = Mathf.Clamp(currentHorizontalSpeed, minHorizontalSpeed, maxHorizontalSpeed);
        }
        return;
    }

    public void UpdatePosition()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += maxVerticalSpeed * moveInput * Time.deltaTime;
        currentPosition.y = Mathf.Min(topBarrier, currentPosition.y);
        transform.position = currentPosition;
    }

    public void UpdateRotation()
    {
        float targetAngle = Mathf.Lerp(-45f, 45f, ((moveInput / 2f) + 0.5f));    // ZeroToOneRange = (input / sizeOfRange) + 0.5f
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, Time.deltaTime * 2f);
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
    }

    public void AngleLimitSnap()
    {
        if (moveInput == 0)
        {
            if (-0.5f < currentAngle && currentAngle < 0.5f)
            {
                currentAngle = 0f;
            }
        }
    }
}