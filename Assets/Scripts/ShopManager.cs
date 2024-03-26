using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopOverlayRef;

    public void ButtonShopEnter()
    {
        shopOverlayRef.SetActive(true);
        Time.timeScale = 0;
    }

    public void ButtonShopExit()
    {
        shopOverlayRef.SetActive(false);
        Time.timeScale = 1;
    }
}
