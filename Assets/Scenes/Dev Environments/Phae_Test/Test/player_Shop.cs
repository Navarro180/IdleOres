using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.HID.HID;
using static System.Net.Mime.MediaTypeNames;

public class player_Shop : MonoBehaviour
{
    [Header("Navigation Buttons")]
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    [Header("Play/ Buy Buttons")]
    [SerializeField] private Button sell;
    [SerializeField] private Button buy;
    [SerializeField] private Button priceText;

    [Header("UpGrade Prices/ Ores")]
    [SerializeField] private int[] upgradePrices;
    private int currentOres;


}
