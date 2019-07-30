using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window_Timer : MonoBehaviour
{
    float resttime=60;
    void Update()
    {
        resttime-=Time.deltaTime;
        GetComponent<Text>().text="Rest Time:"+((int)resttime).ToString();
        if(resttime<=0)
        {
            GameObject.Find("Controller").SetActive(false);
            GameObject.Find("Win").GetComponent<Text>().enabled=true;
            GameObject.Find("timer").GetComponent<Window_Timer>().enabled=false;
        }
    }
}
