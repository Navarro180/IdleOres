using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class passive_Income : MonoBehaviour
{
   // public int updatedMoney;
    //public int cashIncreasePerTimeDetermined;
    //public int cash;
    //public int cashMax;
    public float waitCount;
    public TextMeshProUGUI cashText;
    public float moneyValue;
    public float pointIncreasePerCo;
   // public float timePassed;
    //public float waitSecondCount;

    private void Start()
    {
        //updatedMoney = cashMax;
        //cashIncreasePerTimeDetermined = cash;
    }

    public void FixedUpdate()
    {
        //call for coroutine
        StartCoroutine(waitToIncreaseFunds());
        //(void)moneyValue += pointIncreasePerCo * Time.fixedDeltaTime;

    }

    //coroutine that sets the item inactive for 10 second before turning back on
    IEnumerator waitToIncreaseFunds()
    {
        yield return new WaitForSeconds(waitCount);

        //updatedMoney = (int)((int)cash * Time.deltaTime);
        //cashUI.text = updatedMoney + "Money";
        cashText.text = ((int)moneyValue).ToString();
        moneyValue += pointIncreasePerCo * Time.fixedDeltaTime;
    }

}
