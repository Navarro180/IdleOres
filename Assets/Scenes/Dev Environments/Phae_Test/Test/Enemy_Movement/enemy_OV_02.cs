using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_OV_02 : easyEnemyMovement
{

    //movement
   // public float speed;
    private float dist;
    private float distMin = -10f;
    private float distMax = 17f;
    private Vector3 temp;

    public bool goingRight = true;

    // moves
    void Update()
    {
        Move();
    }

    //makes tree move left and right
    private void Move()
    {

        if (goingRight)
        {
            if (transform.position.x >= -dist)
            {
                temp = Vector3.left;
                SetRandomDirectionSwitch();
                goingRight = false;
            }
        }
        else
        {
            if (transform.position.x <= -dist)
            {
                temp = Vector3.right;
                SetRandomDirectionSwitch();
                goingRight = true;
            }
        }
        transform.position += temp * Time.deltaTime * speed;
    }

    //Switch tree's direction rando between min and max
    private void SetRandomDirectionSwitch()
    {
        dist = Random.Range(distMin, distMax);
    }
}
