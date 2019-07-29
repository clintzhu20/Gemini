using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Controll : MonoBehaviour
{
    public float movement_speed = 4.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        movement_speed = 4.0f;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movement_speed, rb.velocity.y);
        }
        else if (rb.velocity.x > 0) rb.velocity = new Vector2(0.0f,rb.velocity.y);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movement_speed, rb.velocity.y);
        }
        else if (rb.velocity.x < 0) rb.velocity = new Vector2(0.0f, rb.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, movement_speed);
        }
        else if (rb.velocity.y > 0) rb.velocity = new Vector2(rb.velocity.x,0.0f);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, -movement_speed);
        }
        else if (rb.velocity.y < 0) rb.velocity = new Vector2(rb.velocity.x, 0.0f);
    }

}
