using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;

    AudioManager _audioManager;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            _audioManager.PlaySFX(_audioManager.Mine);
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            Destroy(other.gameObject);
        }
        if (other.tag == "HealthPack")
        {
            _audioManager.PlaySFX(_audioManager.Health);
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            Destroy(other.gameObject);
        }
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }

    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
}
