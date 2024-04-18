using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDataPersistance
{
    [Header("Player's Health")]
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
        
    }

#region Damage
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
#endregion

#region Death?
    private void Die()
    {
        //might change
        //Destroy(gameObject);

        //make the player lose half stamina until fix and health
    }
    #endregion

#region Save/Load Data
    public void LoadData(GameData data)
    {
        this._currentHealth = data.playerHealth;
    }

    public void SaveData(ref GameData data)
    {
        data.playerHealth = (int)this._currentHealth;
    }
#endregion
}
