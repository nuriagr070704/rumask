using UnityEngine;

public class red : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    public Rigidbody2D body;  
    public Rigidbody2D body;
    public GameObject bulletPrefab;
    private int ultima_dir= 1;
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
            ultima_dir=1;
        }
        if (Input.GetKey(KeyCode.LeftArrow) )
        {
            body.linearVelocity+=Vector2.left*5; 
            ultima_dir=2;

        }
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            body.linearVelocity+=Vector2.up*5; 
            ultima_dir=3;

        }
        if (Input.GetKey(KeyCode.DownArrow) )
        {
            ultima_dir=4;
            body.linearVelocity+=Vector2.down*5; 
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
           dispara(); 
        }
        
    }
    private void dispara()
    {
        Vector3 dir=Vector3.right;
        if(ultima_dir==1) dir=Vector3.right;
        if(ultima_dir==2) dir=Vector3.left;
        if(ultima_dir==3) dir=Vector3.up;
        if(ultima_dir==4) dir=Vector3.down;
        GameObject bull=Instantiate(bulletPrefab,transform.position+dir*0.6f,Quaternion.identity);
        bull.GetComponent<bullet>().Set_Direction(dir); 
    }
}
