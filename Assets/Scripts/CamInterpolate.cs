using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamInterpolate : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 2f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 currentPosition = transform.position;
        transform.position = Vector3.Lerp(currentPosition, target.position, Time.deltaTime * lerpSpeed);
    }
}
