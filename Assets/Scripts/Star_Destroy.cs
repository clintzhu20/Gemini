using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Spike")
        {
            Destroy(this.gameObject);
        }
    }
}
