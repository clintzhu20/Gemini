using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Shoot : MonoBehaviour
{
    public GameObject player,shoot;
    float NowT,LstT;
    public int forward=1;
    bool flag=false;
    void Start()
    {
        NowT=LstT=Time.fixedTime;
    }
    void Update()
    {
        if(player==null) return;
        NowT=Time.fixedTime;
        if(flag)
        {
            GameObject tmp=Instantiate(shoot,new Vector3(transform.position.x+forward*1.0f,transform.position.y,0),Quaternion.identity);
            Vector2 dis=player.transform.position-transform.position;
            Rigidbody2D rb=tmp.GetComponent<Rigidbody2D>();
            rb.AddForce(dis*10.0f);
            flag=false;
            NowT=LstT=Time.fixedTime;
        }
        else if(NowT-LstT>=2.0f) flag=true;
    }
}
