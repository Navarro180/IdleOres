using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairEvent : MonoBehaviour
{
    public GameObject repairOverlay;
    public GameObject gameManagerRef;

    // Start is called before the first frame update
    void Start()
    {
        repairOverlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int tempHealth = gameManagerRef.GetComponent<GameManager>().currentHealth;      // TODO: This isn't reading correctly for some reason. Good luck!
        if (tempHealth <= 25)
        {
            repairOverlay.SetActive(true);
        }
        return;
    }

    public void ButtonRepair()
    {

    }
}
