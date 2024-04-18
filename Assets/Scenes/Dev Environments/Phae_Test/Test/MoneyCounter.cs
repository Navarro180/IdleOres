
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    private Text txt;

    private void Awake()
    {
        txt = GetComponent<Text>();
    }

    public void Update()
    {
        txt.text = shop_Test.instance.money + "$";
    }
}
