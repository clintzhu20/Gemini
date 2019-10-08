using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window_Timer : MonoBehaviour
{
    float resttime=30;
    void Update()
    {
        resttime-=Time.deltaTime;
        GetComponent<Text>().text="Rest Time:"+((int)resttime).ToString();
        if(resttime<=0)
        {
            GameBool.Game2 = true;
            GameObject.Find("Controller").SetActive(false);
            GameObject.Find("Win").GetComponent<Text>().enabled=true;
            GameObject.Find("timer").GetComponent<Window_Timer>().enabled=false;
        }
    }
}
