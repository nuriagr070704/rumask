using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector2 Direccion;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       body.linearVelocity=Direccion*speed;
    }
    public void Set_Direction(Vector2 dir)
    {
        Direccion= dir;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy_move enemy= collision.collider.GetComponent<enemy_move>();
        if (enemy != null)
        {
            enemy.Hit();
            Destroy(gameObject);
        }    
    }
}
