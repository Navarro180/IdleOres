using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    public float inputVertical = 0f;
    public float inputHorizontal = 0f;
    
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
        UpdateInput();
        UpdateSpeed();
        UpdatePosition();
        UpdateRotation();
        AngleLimitSnap();
    }

    public void UpdateInput()
    {
        inputVertical = Input.GetAxis("Vertical");
        inputHorizontal = Input.GetAxis("Horizontal");
    }

    public void UpdateSpeed()
    {
        if (inputHorizontal != 0)
        {
            currentHorizontalSpeed += inputHorizontal * speedMod * Time.deltaTime;
            currentHorizontalSpeed = Mathf.Clamp(currentHorizontalSpeed, minHorizontalSpeed, maxHorizontalSpeed);
        }
        return;
    }

    public void UpdatePosition()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += maxVerticalSpeed * inputVertical * Time.deltaTime;
        currentPosition.y = Mathf.Min(topBarrier, currentPosition.y);
        transform.position = currentPosition;
    }
    
    public void UpdateRotation()
    {
        float targetAngle = Mathf.Lerp(-45f, 45f, ((inputVertical / 2f) + 0.5f));    // ZeroToOneRange = (input / sizeOfRange) + 0.5f
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, Time.deltaTime * 2f);
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
    
    public void AngleLimitSnap()
    {
        if (inputVertical == 0)
        {
            if (-0.5f < currentAngle && currentAngle < 0.5f)
            {
                currentAngle = 0f;
            }
        }
    }
}
