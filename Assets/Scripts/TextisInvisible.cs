using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextisInvisible : MonoBehaviour
{
    void Update()
    {
        GameObject timer = GameObject.Find("Timer");
        if (DieOnTouch.ifTouch == true)
        {
            GetComponent<Text>().enabled = true;
            timer.GetComponent<Timer>().enabled = false;

        }
    }
}