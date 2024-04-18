using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryNumbers : MonoBehaviour
{
    public GameObject bugs;
    public GameObject bones;
    public GameObject coal;
    public GameObject gold;
    public GameObject silver;
    public GameObject diamonds;
    public GameObject drillBit_02;
    public GameObject drillBit_03;

    public int bugs_Amount;
    public int bones_Amount;
    public int coal_Amount;
    public int gold_Amount;
    public int silver_Amount;
    public int diamonds_Amount;
    public int player_Money;
    public int drillBit_02_Purchase_Amount;
    public int drillBit_03_Purchase_Amount;


    public GameObject sellButton;
    private void Start()
    {
        player_Money = sellButton.GetComponent<Buy>().money;
        Debug.Log("help");
    }
}
