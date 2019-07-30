using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_upward : MonoBehaviour
{
    public static float move_up_factor = 1.7f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up
                           * Child.movement_speed
                           * move_up_factor * Time.deltaTime;
    }
}
