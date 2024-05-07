using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerController playerRef;
    AudioManager _audioManager;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        
    }
    #region Collider
    private void OnTriggerEnter(Collider other)
    {
        //this is located on the player health
        //if (other.tag == "Mine")
        //{
        //    Destroy(other.gameObject);

        //}
        if (other.tag == "BugRelic")
        {
            _audioManager.PlaySFX(_audioManager.BugRelic);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 25;
        }
        else if (other.tag == "bone")
        {
            _audioManager.PlaySFX(_audioManager.bone);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 50;
        }
        else if (other.tag == "SmallRock")
        {
            _audioManager.PlaySFX(_audioManager.rock);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 1;
        }
        else if (other.tag == "LargeRock")
        {
            _audioManager.PlaySFX(_audioManager.rock);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 2;
        }
        return;
    }
    #endregion
}
