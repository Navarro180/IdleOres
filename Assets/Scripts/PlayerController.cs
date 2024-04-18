using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour//, IDataPersistance
{
    public float moveInputX;
    public float moveInputY;
    public GameObject shopRef;

    [Header("==== UPGRADE MODULES ====")]
    public float upgradeMaxVerticalSpeed = 1.5f;
    public float upgradeAcceleration = 1.0f;
    public float upgradeMaxHorizontalSpeed = 3.0f;


    [Header("Vertical Data")]
    public float currentAngle = 0f;
    public float topBarrier = 10.0f;

    [Header("Horizontal Data")]
    public float currentHorizontalSpeed = 0.7f;
    public float minHorizontalSpeed = 0.5f;

    private void Update()
    {
        Move();
        Boost();
    }

    #region BoostBarUI
    public void SetRunSpeed(float speed)
    {
        currentHorizontalSpeed = speed;
    }
    #endregion

    private void Move()
    {
        moveInputY = UserInput.instance.MoveInput.y;
        UpdatePosition();
        UpdateRotation();
        AngleLimitSnap();
    }
    private void Boost()
    {
        moveInputX = UserInput.instance.MoveInput.x;
        UpdateSpeed();
    }

    public void UpdateSpeed()
    {
        if (moveInputX != 0)
        {
            currentHorizontalSpeed += moveInputX * upgradeAcceleration * Time.deltaTime;
            currentHorizontalSpeed = Mathf.Clamp(currentHorizontalSpeed, minHorizontalSpeed, upgradeMaxHorizontalSpeed);
        }
        return;
    }

    public void UpdatePosition()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += upgradeMaxVerticalSpeed * moveInputY * Time.deltaTime;
        currentPosition.y = Mathf.Min(topBarrier, currentPosition.y);
        transform.position = currentPosition;
    }

    public void UpdateRotation()
    {
        float targetAngle = Mathf.Lerp(-45f, 45f, ((moveInputY / 2f) + 0.5f));    // ZeroToOneRange = (input / sizeOfRange) + 0.5f
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, Time.deltaTime * 2f);
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
    }

    public void AngleLimitSnap()
    {
        if (moveInputY == 0)
        {
            if (-0.5f < currentAngle && currentAngle < 0.5f)
            {
                currentAngle = 0f;
            }
        }
    }

    public void LoadData(GameData data)
    {
        //this.transform.position = data.playerPos;
    }

    public void SaveData(ref GameData data)
    {
        //data.playerPos = this.transform.position;
    }
}