using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class player_move : MonoBehaviour{ 
    
    private Rigidbody2D body2D;  
    private float Vertical,Horizontal;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        body2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update(){
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }
    //Update para fisicas
    private void FixedUpdate()
    {
        body2D.linearVelocity= new Vector2(speed*Horizontal,speed*Vertical);
    }
}
