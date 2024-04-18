using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyEnemyMovement : MonoBehaviour
{
    public float speed;
    public int health;

    public GameObject coal;
    public GameObject enemy;

    public bool enemyGone = true;

    //move to the left
    public void Awake()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }

    public void Start()
    {
        enemyGone = false;
    }

    public void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;

            if (health <= 0)
            {
              if (true)
              {
                //gameObject.
                enemy.SetActive(false);
            }
                SpawnReward();
            }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "boost_Drill")
        {
            Debug.Log("drill collision");
            health = 0;
        }
    }

    public void SpawnReward()
    {
            Instantiate(coal);
    }

}
