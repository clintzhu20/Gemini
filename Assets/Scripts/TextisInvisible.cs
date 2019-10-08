using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextisInvisible : MonoBehaviour
{
    void start()
    {
        DieOnTouch.ifTouch = false;
        GameObject timer = GameObject.Find("Timer");
        timer.GetComponent<Timer>().enabled = true;
        GetComponent<Text>().text = "";
    }
    void Update()
    {
        if (DieOnTouch.ifTouch)
        {

        }
    }
}