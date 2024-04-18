using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAdd : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            shop_Test.instance.money += 100;
            shop_Test.instance.Save();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            shop_Test.instance.money -= 100;
            shop_Test.instance.Save();
        }
    }
}
