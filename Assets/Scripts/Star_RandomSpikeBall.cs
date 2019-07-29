using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_RandomSpikeBall : MonoBehaviour
{
    public GameObject Spike;
    float NowT,LstT;
    bool flag=true;
    void Start()
    {
        NowT=LstT=Time.fixedTime;
    }
    void Update()
    {
        NowT=Time.fixedTime;
        if(flag)
        {
            Instantiate(Spike,new Vector3(Random.Range(-8.7f,8.7f),6.0f,0),Quaternion.identity);
            NowT=LstT=Time.fixedTime;
            flag=false;
        }
        if(!flag)
        {
            if(NowT-LstT>=0.2f)
                flag=true;
        }
    }
}
