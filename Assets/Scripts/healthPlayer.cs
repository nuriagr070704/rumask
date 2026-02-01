using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class healthPlayer : MonoBehaviour
{
    public int maxHealth = 8;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DamageReceived(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

   
}