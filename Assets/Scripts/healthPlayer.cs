using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class healthPlayer : MonoBehaviour
{
    public int maxHealth = 7;
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

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Enemy") 
    //     || collision.gameObject.CompareTag("Enemy1")
    //     || collision.gameObject.CompareTag("Enemy2")
    //     || collision.gameObject.CompareTag("Enemy3")
    //     || collision.gameObject.CompareTag("Enemy4"))
    //     {
    //         DamageReceived(1);
    //     }
    // }
}