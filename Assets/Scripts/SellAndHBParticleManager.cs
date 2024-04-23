using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SellAndHBParticleManager : MonoBehaviour
{
    public PlayerController playerRef;

    public bool isEmitting;
    public bool lastStoredBoolIsEmitting;

    [Header("==== Logic Related Variables ====")]
    public long localMoneyRef;
    public long localOreValueRef;
    public TextMeshProUGUI localMoneyTextRef;
    public TextMeshProUGUI localOreTextRef;

    [Header("==== Particle Systems ====")]
    public ParticleSystem rocks;
    public ParticleSystem ore1;
    public ParticleSystem ore4;
    public ParticleSystem ore6;
    public ParticleSystem ore7;

    private void Awake()
    {
        Debug.Log("Awake called");
        HungryBoyParticleBoolFalseOnExitOverlay();
    }

    private void Start()
    {
        Debug.Log("Start called");
        EmitPlay(isEmitting);
    }

    // Currency Transfer handled here
    private void Update()
    {
        localMoneyRef = playerRef.currentMoney;
        localOreValueRef = playerRef.currentOreValue;
        localMoneyTextRef.text = localMoneyRef.ToString();
        localOreTextRef.text = localOreValueRef.ToString();
        lastStoredBoolIsEmitting = isEmitting;
        if (isEmitting)
        {
            EmitPlay(lastStoredBoolIsEmitting);
        }
    }

    public void EmitPlay(bool isItEmitting)
    {
        Debug.Log("EmitPlay called with isItEmitting = " + isItEmitting);
        if (isItEmitting && localOreValueRef > 0)
        {
            rocks.Play();
            ore1.Play();
            ore4.Play();
            ore6.Play();
            ore7.Play();

            MoneyTransfer();
        }
        else
        {
            isEmitting = false;
            rocks.Stop();
            ore1.Stop();
            ore4.Stop();
            ore6.Stop();
            ore7.Stop();
        }
    }

    public void ButtonHitBoolFlip()
    {
        isEmitting = !isEmitting;
        EmitPlay(isEmitting);
    }

    public void HungryBoyParticleBoolFalseOnExitOverlay()
    {
        EmitPlay(false);
    }

    // Handles the transfer of value from ore appraisal value to actual currency
    // **Made overly complicated for dramatic effect in UI
    public void MoneyTransfer()
    {
        if (playerRef.currentOreValue > 500000)
        {
            long transferValue = playerRef.currentOreValue / 2;
            playerRef.currentOreValue -= transferValue;
            playerRef.currentMoney += transferValue;
            return;
        }
        else if (playerRef.currentOreValue > 100000)
        {
            playerRef.currentOreValue -= 10000;
            playerRef.currentMoney += 10000;
            return;
        }
        else if (playerRef.currentOreValue > 10000)
        {
            playerRef.currentOreValue -= 1000;
            playerRef.currentMoney += 1000;
            return;
        }
        else if (playerRef.currentOreValue > 1000)
        {
            playerRef.currentOreValue -= 100;
            playerRef.currentMoney += 100;
            return;
        }
        if (playerRef.currentOreValue > 100)
        {
            playerRef.currentOreValue -= 10;
            playerRef.currentMoney += 10;
            return;
        }
        else if (playerRef.currentOreValue > 0)
        {
            playerRef.currentOreValue -= 1;
            playerRef.currentMoney += 1;
            return;
        }
        return;
    }
}
