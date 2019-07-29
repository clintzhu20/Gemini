using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_MoveDown : MonoBehaviour
{
    public float speed=1.0f;
    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
    }
}
