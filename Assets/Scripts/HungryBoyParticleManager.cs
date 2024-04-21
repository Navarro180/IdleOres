using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryBoyParticleManager : MonoBehaviour
{
    public bool isEmitting;

    [Header("==== Particle Systems ====")]
    public ParticleSystem rocks;
    public ParticleSystem ore1;
    public ParticleSystem ore4;
    public ParticleSystem ore6;
    public ParticleSystem ore7;

    private void Start()
    {
        isEmitting = false;
        EmitPlay(isEmitting);
    }

    public void EmitPlay(bool isItEmitting)
    {
        if (isItEmitting)
        {
            rocks.Play();
            ore1.Play();
            ore4.Play();
            ore6.Play();
            ore7.Play();
        }
        else
        {
            rocks.Stop();
            ore1.Stop();
            ore4.Stop();
            ore6.Stop();
            ore7.Stop();
        }
        return;
    }

    public void ButtonHitBoolFlip()
    {
        isEmitting = !isEmitting;
        EmitPlay(isEmitting);
    }

    public void HungryBoyParticleBoolFalseOnExitOverlay()
    {
        EmitPlay(false);
    }
}
