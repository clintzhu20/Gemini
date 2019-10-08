using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer2 : MonoBehaviour
{
    public Text Tim;
    public Text WinText;
    float NowT, LstT, LstT2;
    public GameObject player;
    void Start()
    {
        NowT = LstT = LstT2 = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        int diff = 45 - (int)(NowT - LstT2);
        Tim.text =  diff.ToString();
        NowT = Time.fixedTime;
        if (NowT - LstT >= 0.05f)
        {
            LstT = NowT;
        }
        if (NowT - LstT2 >= 45.0f)
        {
            Tim.text = "0";
            DodgeBall.winwin = true;
            WinText.text = "You Win!";
            GameObject shoot = GameObject.Find("ShootController");
            shoot.GetComponent<Ball_Appear>().enabled = false;
            Destroy(player);
        }
    }
}
