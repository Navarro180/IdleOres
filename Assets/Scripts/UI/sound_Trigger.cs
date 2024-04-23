using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_Trigger : MonoBehaviour
{
    public AudioSource source;

    [Header("==== Auio Files ====")]
    public AudioClip Mine;
    public AudioClip ore;
    public AudioClip rock;
    public AudioClip BugRelic;
    public AudioClip bone;
    public AudioClip Health;

    //public LayerMask ores;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mine")
        {
            source.PlayOneShot(Mine);
        }

        if (collision.gameObject.tag == "BugRelic")
        {
            source.PlayOneShot(BugRelic);
        }

        if (collision.gameObject.tag == "bone")
        {
            source.PlayOneShot(bone);
        }

        if (collision.gameObject.tag == "Large")
        {
            source.PlayOneShot(rock);
        }
        if (collision.gameObject.tag == "Small")
        {
            source.PlayOneShot(rock);
        }

        if (collision.gameObject.tag == "ore_01")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_02")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_03")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_04")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_05")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_06")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_07")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_08")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "ore_09")
        {
            source.PlayOneShot(ore);
        }

        if (collision.gameObject.tag == "Health")
        {
            source.PlayOneShot(Health);
        }
    }
}
