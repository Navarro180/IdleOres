using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player_Pick_Up : MonoBehaviour
{
    public int bugs = 0;
    [SerializeField] public TextMeshProUGUI bugText;
    private object myTextElement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bugs")
        {
            bugs++;
            Debug.Log("pick up bugs");
            bugs = bugs;
        }
    }

    public void Start()
    {
        SetCountText();
    }

    public void SetCountText()
    {
        bugText.text = "Bugs: ";
    }
}
