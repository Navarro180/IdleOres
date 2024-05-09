using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSlowManager : MonoBehaviour
{
    public GameObject playerRef;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.currentHealth <= 10)
        {
            playerRef.GetComponent<PlayerController>().upgradeMaxHorizontalSpeed = playerRef.GetComponent<PlayerController>().upgradeMaxHorizontalSpeed / 2;
        }
    }
}
