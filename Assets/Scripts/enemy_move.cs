using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy_move : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    public float speed = 2f;
    public float detectionRadius = 5f;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer < detectionRadius)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            movement = new Vector2(direction.x, direction.y);
        }
        else
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}