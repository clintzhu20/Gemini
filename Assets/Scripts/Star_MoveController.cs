using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_MoveController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=5.0f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity=new Vector2(-speed,rb.velocity.y);
        }
        else if(rb.velocity.x<0) rb.velocity=new Vector2(0,rb.velocity.y);
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity=new Vector2(speed,rb.velocity.y);
        }
        else if(rb.velocity.x>0) rb.velocity=new Vector2(0,rb.velocity.y);
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity=new Vector2(rb.velocity.x,speed);
        }
        else if(rb.velocity.y>0) rb.velocity=new Vector2(rb.velocity.x,0);
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity=new Vector2(rb.velocity.x,-speed);
        }
        else if(rb.velocity.y<0) rb.velocity=new Vector2(rb.velocity.x,0);
    }
}
