using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    public static float movement_speed = 12.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        movement_speed = 12.0f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(movement_speed, rb.velocity.y * 2);
        }
        else if (rb.velocity.x > 0) rb.velocity = new Vector2(0.0f, rb.velocity.y * 2);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(-movement_speed, rb.velocity.y);
        }
        else if (rb.velocity.x < 0) rb.velocity = new Vector2(0.0f, rb.velocity.y);
    }
}
