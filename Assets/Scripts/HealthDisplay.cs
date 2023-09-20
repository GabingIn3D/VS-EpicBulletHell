using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    private int damage = 1;

  [SerializeField] GameOver gameOver;
    public Invincible invincible;
    public HealthBar healthBar;


    private void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        HealthMeter();
    }

    private void HealthMeter()
    {
       

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            gameOver.SetGameOver();
        }

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            healthBar.SetHealth(currentHealth);
        }

    }

    public void Damage()
    {
        if (invincible.isInvincible) return;

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        StartCoroutine(invincible.TempInvincibility());
    }

    private void GameOver()
    {

    }

}
