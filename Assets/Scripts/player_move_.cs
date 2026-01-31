
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class player_move_ : MonoBehaviour
{ 
    
    public Rigidbody2D body;  
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
           body.linearVelocity=Vector2.up*10; 
        }
        
    }
    
}
