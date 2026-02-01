using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy_move : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    public GameObject maskPrefab;
    public float speed = 2f;
    public float detectionRadius = 5f;
    public int baseDamage = 1;
    public MaskData equippedMask;

    private int totalDamage;
    private Vector2 movement;
    private int health=4;
    private bool redSeen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        totalDamage = baseDamage;

        if (equippedMask != null)
        {
            totalDamage += equippedMask.extraDamage;
            health += equippedMask.extraLife;
        }
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer < detectionRadius || redSeen)
        {
            redSeen = true;
            Vector2 direction = (player.position - transform.position).normalized;
            movement = new Vector2(direction.x, direction.y);
        }
        else
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        healthPlayer red_life = collision.collider.GetComponent<healthPlayer>();
        red_life?.DamageReceived(totalDamage);
    }
     public void Hit(int damage_)
    {
        health = health-damage_;
        if (health <= 0) {
            if (maskPrefab != null)
            {
                Instantiate(maskPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
    public void AddExtraDamage(int amount)
    {
        totalDamage+=amount;
    }
}