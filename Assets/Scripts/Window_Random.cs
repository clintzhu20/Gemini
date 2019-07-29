using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Random : MonoBehaviour
{
    public GameObject[] Win;
    public  bool[] flag={false,false,false,false};
    public  bool[] cover={false,false,false,false};
    float NowT,LstT;
    bool Timeflag=false;
    public int count=0;
    void Start()
    {
        NowT=LstT=Time.fixedTime;
    }
    void Update()
    {
        //print(count);
        if(count>=3) return;
        NowT=Time.fixedTime;
        if(NowT-LstT>=0.6f) Timeflag=false;
        if(Timeflag) return;
        int ShowWin;
        //do
        //{
            ShowWin=Random.Range(0,4);
        //if(cover[ShowWin]) ShowWin=(ShowWin==3?0:ShowWin+1);
        int tmpcount=0;
        while(flag[ShowWin]||cover[ShowWin])
        {
            ShowWin=(ShowWin==3?0:ShowWin+1);
            tmpcount++;
            if(tmpcount>=5) return;
        }
        //}while(flag[ShowWin]||cover[ShowWin]);
        Win[ShowWin].GetComponent<SpriteRenderer>().enabled=true;
        flag[ShowWin]=true;
        count++;
        Timeflag=true;
        NowT=LstT=Time.fixedTime;
    }
}
