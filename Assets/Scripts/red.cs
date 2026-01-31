using UnityEngine;

public class red : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    public Rigidbody2D body;  
    public Rigidbody2D body;
    void Start(){
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update(){
        //frenar red
        body.linearVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow) )
        {
            body.linearVelocity += Vector2.right * 5;
        }
        if (Input.GetKey(KeyCode.LeftArrow) )
        {
           body.linearVelocity+=Vector2.left*5; 
        }
        if (Input.GetKey(KeyCode.UpArrow) )
        {
           body.linearVelocity+=Vector2.up*5; 
        }
        if (Input.GetKey(KeyCode.DownArrow) )
        {
           body.linearVelocity+=Vector2.down*5; 
        }
        if (Input.GetKey(KeyCode.Space) )
        {
           dispara(); 
        }
        
    }
    private void dispara()
    {
        Instantiate(bullet,transfor.position,Quaternion.identity);
    }
}
