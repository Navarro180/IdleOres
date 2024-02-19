using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DevSpedometer : MonoBehaviour
{
    public TextMeshProUGUI spedometer;
    public PlayerController playerControllerRef;

    // Update is called once per frame
    void Update()
    {
        float speedReadout = playerControllerRef.currentHorizontalSpeed;
        spedometer.text = "Speed: " + speedReadout;
    }
}
