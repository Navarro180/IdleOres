using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Reward : MonoBehaviour
{
    //if player kills enemy- increase coal
    public GameObject coal;
    GameObject enemy;

    public bool enemyGone = true;

    private void Start()
    {
        enemyGone = false;
    }

    public void Update()
    {
        if (GetComponent<easyEnemyMovement>())
        {
            //Player.GetComponent<PlayerInventoryNumbers>().player_Money = cash;
            enemy.GetComponent<easyEnemyMovement>().health = 0;
            enemyGone = true;
            if (enemyGone = true)
            {
                Instantiate(coal);
            }
        }
    }
}
