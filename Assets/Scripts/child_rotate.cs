using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child_rotate : MonoBehaviour
{
    public float angle = 0.2f;
    public float speed = 1.0f;
    int flag = 1;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 10) * speed * Time.deltaTime * flag);
            print(transform.rotation.z);
            print(flag);
            if (transform.rotation.z <= -angle || transform.rotation.z >= angle) flag = -flag;
        }
        else transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }
}