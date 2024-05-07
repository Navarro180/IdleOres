using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public TextMeshProUGUI gameScreenArmorHealthText;
    public GameManager gameManager;
    public AudioManager _audioManager;

    public ShopManagerGolfball shopManager;

    [SerializeField] HealthBar healthBar;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Update()
    {
        gameScreenArmorHealthText.text = gameManager.currentHealth.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mine")
        {
            _audioManager.PlaySFX(_audioManager.Mine);
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            int localCurrentHealth = GameManager.gameManager._playerHealth.Health;
            Destroy(other.gameObject);
            gameScreenArmorHealthText.text = localCurrentHealth.ToString();
        }
        if (other.tag == "HealthPack")
        {
            _audioManager.PlaySFX(_audioManager.Health);
            PlayerHeal(100);             
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            Destroy(other.gameObject);
            gameScreenArmorHealthText.text = gameManager._playerHealth.Health.ToString();
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
