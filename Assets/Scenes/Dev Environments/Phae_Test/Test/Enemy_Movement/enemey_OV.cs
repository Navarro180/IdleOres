using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemey_OV : easyEnemyMovement
{
    //Loop movement
   // public float speed;
    private float dist;
    private float distMin = -10f;
    private float distMax = 10f;
    private Vector3 temp;

    public bool goingDown = true;

    private void Start()
    {
        moveAround();
    }

    void Update()
    {
        moveAround();
        moveAround();
    }

    private void moveAround()
    {
        if (goingDown)
        {
            if (transform.position.x >= -dist)
            {
                temp = Vector3.down;
                randoSwitch();
                goingDown = false;
            }
        }
        else
        {
            if (transform.position.y <= -dist)
            {
                temp = Vector3.left;
                randoSwitch();
                goingDown = true;
            }
        }
        transform.position += temp * Time.deltaTime * speed;
    }

    //Switch tree's direction rando between min and max
    private void randoSwitch()
    {
        dist = Random.Range(distMin, distMax);
    }
}
