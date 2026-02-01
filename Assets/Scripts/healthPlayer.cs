using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class healthPlayer : MonoBehaviour
{
    public int maxHealth = 7;
    public int currentHealth;
    public GameOverScreen GameOverScreen;

    public void GameOver()
    {
        GameOverScreen.SetUp();
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DamageReceived(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            // Destroy(gameObject);
            GameOver();
        }
    }
}