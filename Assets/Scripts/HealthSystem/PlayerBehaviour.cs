using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            Destroy(other.gameObject);
        }
        if (other.tag == "HealthPack")
        {
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
