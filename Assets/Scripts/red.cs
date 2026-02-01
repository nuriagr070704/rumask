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
    public bool tieneMascara=false;

    // Update is called once per frame
    void Update(){
        //frenar red
        body.linearVelocity = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow) )
        {
            ultima_dir=1;
        }
        if (Input.GetKey(KeyCode.LeftArrow) )
        {
            ultima_dir=2;

        }
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            ultima_dir=3;

        }
        if (Input.GetKey(KeyCode.DownArrow) )
        {
            ultima_dir=4;
        }


        if (Input.GetKey(KeyCode.D) ) body.linearVelocity += Vector2.right * 5;
        if (Input.GetKey(KeyCode.A) ) body.linearVelocity+=Vector2.left*5; 
        if (Input.GetKey(KeyCode.W) ) body.linearVelocity+=Vector2.up*5; 
        if (Input.GetKey(KeyCode.S) )   body.linearVelocity+=Vector2.down*5; 
        
        if (Input.GetKeyDown(KeyCode.Space) )
        {
           dispara(); 
        }
        
    }
    public void ActivarMascara()
    {
        tieneMascara=true;
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
        if (tieneMascara) {

            bull.GetComponent<bullet>().damage=2;
        }
        Destroy(bull,1f);    
    }
}
