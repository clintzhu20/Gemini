using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Phase2 : MonoBehaviour
{
    GameObject Phase2;
    public float speed=2.0f;
    void Start()
    {
        Phase2=GameObject.Find("Phase2");
        //Phase2.SetActive(true);
    }
    void Update()
    {
        Phase2.transform.Translate(Vector3.down*speed*Time.deltaTime);
    }
}
