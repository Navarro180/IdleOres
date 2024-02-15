using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float inputVertical = 0;
    public float maxVerticalSpeed = 1.5f;

    public float topBarrier = 4.0f;

    public float currentAngle = 0f;

    private void Update()
    {
        UpdateInput();
        UpdatePosition();
        UpdateRotation();
    }

    public void UpdateInput()
    {
        inputVertical = Input.GetAxis("Vertical");
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
        float targetAngle = Mathf.Lerp(-45f, 45f, ((inputVertical / 2f) + 0.5f));       // ZeroToOneRange = (input / sizeOfRange) + 0.5f
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, Time.deltaTime * 2f);
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle + 90f);
    }


}
