using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    //when player clicks on button, minus the amount of money & add the item to inventory
    //find door script

    public GameObject Player;
    public int money;
    public int addAmount;
    private void Start()
    {
        Player.GetComponent<PlayerInventoryNumbers>().player_Money = money;
        if (money == 0)
        {
            return;
        }
        else
        {
            AddAmount();
        }
    }

    public void AddAmount()
    {
        money = money + addAmount;
        Player.GetComponent<PlayerInventoryNumbers>().player_Money = money;
    }
}
