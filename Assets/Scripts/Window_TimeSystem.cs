using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window_TimeSystem : MonoBehaviour
{
    public float timer=10.0f;
    RectTransform timeline;
    void Start()
    {
        timeline=GameObject.Find("TimeLine").GetComponent<RectTransform>();
    }
    void Update()
    {
        if(GetComponent<Window_Random>().count>=1) timer-=Time.deltaTime;
        else timer+=Time.deltaTime*2;
        timeline.sizeDelta=new Vector2(10*timer,10);
        timeline.anchoredPosition=new Vector2(-5*timer-4,-12);
        if(timer<=0)
        {
            GameObject.Find("Controller").SetActive(false);
            GameObject.Find("timer").GetComponent<Window_Timer>().enabled=false;
            GameObject.Find("Over").GetComponent<Text>().enabled=true;
        }
    }
}
