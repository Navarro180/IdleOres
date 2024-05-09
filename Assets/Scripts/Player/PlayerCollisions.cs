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

    #region Collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BugRelic")        // ====== MISC. =========================
        {
            _audioManager.PlaySFX(_audioManager.BugRelic);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 50;
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
            playerRef.currentOreValue += 2;
        }
        else if (other.tag == "LargeRock")
        {
            _audioManager.PlaySFX(_audioManager.rock);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 4;
        }
        else if (other.tag == "ore_01")     // ====== ORES ==========================
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 10;
        }
        else if (other.tag == "ore_02")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 20;
        }
        else if (other.tag == "ore_03")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 30;
        }
        else if (other.tag == "ore_04")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 50;
        }
        else if (other.tag == "ore_05")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 80;
        }
        else if (other.tag == "ore_06")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 100;
        }
        else if (other.tag == "ore_07")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 300;
        }
        else if (other.tag == "ore_08")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 500;
        }
        else if (other.tag == "ore_09")
        {
            _audioManager.PlaySFX(_audioManager.ore);
            Destroy(other.gameObject);
            playerRef.currentOreValue += 800;
        }
        return;
    }
    #endregion
}
