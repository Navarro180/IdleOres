using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float _maxHealth = 5f;

    private float _currentHealth;

    private HB hb;

    private void Start()
    {
        _currentHealth = _maxHealth;

        //bc its under the player
        hb = GetComponentInChildren<HB>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Dmg(1);
        }
    }

    public void Dmg(float dmgAmount)
    {
        //damage
        _currentHealth -= dmgAmount;

        //update health bar
        hb.UpdateHealthBar(_maxHealth, _currentHealth);

        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //might change
        Destroy(gameObject);
    }
}
