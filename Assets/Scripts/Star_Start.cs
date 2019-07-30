using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star_Start : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Text>().enabled=false;
            GameObject.Find("Control").GetComponent<Star_Controller>().enabled=true;
        }
    }
}
