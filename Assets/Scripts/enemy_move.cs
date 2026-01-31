using UnityEngine;

public class enemy_move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform playerTransform;
    public float speed = 2f;
    public float detectionRadius = 5f;
    
    //Posicion ini enemy
    private Vector2 startingPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position; 

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) playerTransform = player.transform;
    }

    void FixedUpdate()
    {
        if (playerTransform == null) return;

        //distancia entre enemigo y prota
        float distanceToPlayer = Vector2.Distance(transform.position, playerTransform.position);

        if (distanceToPlayer < detectionRadius)
        {
            moveTo(playerTransform.position); //si lo detecta, se mueve hacia el prota
        }
        else
        {
            moveTo(startingPosition); //si no lo detecta, va a su posicion ini
        }
    }

    void moveTo(Vector2 objetivo)
    {
        if (Vector2.Distance(transform.position, objetivo) < 0.1f)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
        Vector2 direccion = (objetivo - (Vector2)transform.position).normalized;
        rb.linearVelocity = direccion * speed;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}