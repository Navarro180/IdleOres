using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour, IDataPersistance
{
    public float moveInput;
    public GameObject shopRef;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI oreText;

    [Header("==== UPGRADE MODULES ====")]
    public float upgradeMaxVerticalSpeed = 1.5f;
    public float upgradeAcceleration = 1.0f;
    public float upgradeMaxHorizontalSpeed = 3.0f;

    [Header("==== SCORE VALUES ====")]
    public int currentOreValue = 0;
    public int currentMoney = 0;

    [Header("==== Vertical Data ====")]
    public float currentAngle = 0f;
    public float topBarrier = 10.0f;
    public float bottomBarrier = -30;

    [Header("==== Horizontal Data ====")]
    public float currentHorizontalSpeed = 0.7f;
    public float minHorizontalSpeed = 0.5f;

    private void Update()
    {
        Move();
        Boost();
    }

    public void FixedUpdate()
    {
        moneyText.text = currentMoney.ToString();
        oreText.text = currentOreValue.ToString();
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

    #region Movement
    public void UpdateSpeed()
    {
        if (moveInput != 0)
        {
            currentHorizontalSpeed += moveInput * upgradeAcceleration * Time.deltaTime;
            currentHorizontalSpeed = Mathf.Clamp(currentHorizontalSpeed, minHorizontalSpeed, upgradeMaxHorizontalSpeed);
        }
        return;
    }

    public void UpdatePosition()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += upgradeMaxVerticalSpeed * moveInput * Time.deltaTime;
        currentPosition.y = Mathf.Min(topBarrier, currentPosition.y);
        
        if (currentPosition.y <= bottomBarrier)
        {
            return;
        }
        
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
    #endregion

    #region Save/Load
    void IDataPersistance.LoadData(GameData data)
    {
        //throw new NotImplementedException();
        this.currentMoney = data.moneyText;
        this.currentOreValue = data.valueText;
    }

    void IDataPersistance.SaveData(ref GameData data)
    {
        //throw new NotImplementedException();
        data.moneyText = this.currentMoney;
        data.valueText = this.currentOreValue;
    }
    #endregion
}