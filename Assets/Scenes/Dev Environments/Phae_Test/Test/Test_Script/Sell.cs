using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    //when player pushes button, add money & subtract item from inventory
    //use door script
    public GameObject Player;
    public GameObject SellButton;
    public int minusAmount;
    private int cash;
    private void Start()
    {
        //SellButton.GetComponent<Buy>().money = cash;
        Player.GetComponent<PlayerInventoryNumbers>().player_Money = cash;

        if (cash == 0)
        {
            return;
        }
        else
        {
            SubtractAmount();
        }
    }

    public void SubtractAmount()
    {
        cash = cash - minusAmount;
        Player.GetComponent<PlayerInventoryNumbers>().player_Money = cash;
        cash = SellButton.GetComponent<Buy>().money;
    }

}
