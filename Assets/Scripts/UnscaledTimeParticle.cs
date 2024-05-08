using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnscaledTimeParticle : MonoBehaviour
{
    //for somw reason is not calculating the class
    //public SellAndHBParticleManager manager;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale < 0.01f)
        {
            GetComponent<ParticleSystem>().Simulate(Time.unscaledDeltaTime, true, false);
        }
    }
    
}
