using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour, IDataPersistance
{
    public static PlayerController instance;

    public float moveInput;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI moneyTextShopPanel;
    public TextMeshProUGUI oreText;

    [Header("==== UPGRADE MODULES ====")]
    public float upgradeMaxVerticalSpeed = 1.5f;
    public float upgradeAcceleration = 1.0f;
    public float upgradeMaxHorizontalSpeed = 3.0f;

    [Header("==== SCORE VALUES ====")]
    public long currentOreValue;
    public long currentMoney;

    [Header("==== Vertical Data ====")]
    public float currentAngle = 0f;
    public float topBarrier = 10.0f;
    public float bottomBarrier = -30;

    [Header("==== Horizontal Data ====")]
    public float currentHorizontalSpeed = 0.7f;
    public float minHorizontalSpeed = 0.5f;

    // Awake/Singleton Setup for MoveSim Manager referencing
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadData(GameData data)
    {
        this.currentOreValue = data.valueText;
        this.currentMoney = data.moneyText;
    }

    public void SaveData(GameData data)
    {
        data.valueText = (int)this.currentOreValue;
        data.moneyText = (int)this.currentMoney;
    }

    private void Update()
    {
        Move();
        Boost();

        moneyText.text = currentMoney.ToString();
        moneyTextShopPanel.text = currentMoney.ToString();
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

}