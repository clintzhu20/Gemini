using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealWarp : MonoBehaviour
{
    public int piece_index=0;
    float width=0.0f;
    void Start()
    {
        width=GetComponent<Renderer>().bounds.extents.y*2;
        transform.position=new Vector3(transform.position.x,-width*piece_index,0);
    }
    void Update()
    {
        if(transform.position.y>width)
        {
            transform.position+=Vector3.down*width*2;
        }
    }
}
