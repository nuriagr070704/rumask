using UnityEngine;

public class red : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    public Rigidbody2D body;  
    public Rigidbody2D body;
    public GameObject bulletPrefab;
    private int ultima_dir= 1;
    public enum Tipo_mascara
    {
        Ninguna,
        Fuego,
        Agua,
        Iron,
        Planta,
        Extra
    }
    
    void Start(){
        body = GetComponent<Rigidbody2D>();
    }

    public Tipo_mascara mascaraActual = Tipo_mascara.Ninguna;
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

    public void ActivarMascara(Tipo_mascara mask)
    {   bool cambiar = true;
        if (mascaraActual != Tipo_mascara.Extra && mascaraActual != Tipo_mascara.Iron)
        {
            cambiar=false;
        }
        mascaraActual = mask;
        if (mascaraActual == Tipo_mascara.Extra) {
            GetComponent<healthPlayer>().currentHealth = 18;
        }
        else if (mascaraActual == Tipo_mascara.Iron)
        {
            GetComponent<healthPlayer>().currentHealth = 13;
        }
        else if (cambiar )
        {
            GetComponent<healthPlayer>().currentHealth = 8;

        }
        /*else if (mascaraActual == Tipo_mascara.Iron)
        {
            GetComponent<healthPlayer>().currentHealth = 1;
        }*/
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

        if (mascaraActual == Tipo_mascara.Fuego) {
            bull.GetComponent<bullet>().damage = 4;
        }
        else if (mascaraActual == Tipo_mascara.Agua || mascaraActual == Tipo_mascara.Iron)
        {
            bull.GetComponent<bullet>().damage = 3;
        }
        else if (mascaraActual == Tipo_mascara.Planta || mascaraActual == Tipo_mascara.Extra)
        {
            bull.GetComponent<bullet>().damage =2;
        }
        
        Destroy(bull,1f);    
    }
}
