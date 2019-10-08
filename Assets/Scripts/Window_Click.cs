using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Click : MonoBehaviour
{
    public GameObject[] cl;
    public bool[] cover={false,false,false,false};
    int LstPos=-1;
    int GetMousePos(Vector3 pos)
    {
        // if(pos.x>=212&&pos.x<=904&&pos.y<=1141&&pos.y>=660) return 0;
        // if(pos.x>=1247&&pos.x<=1937&&pos.y<=1141&&pos.y>=660) return 1;
        // if(pos.x>=212&&pos.x<=904&&pos.y<=536&&pos.y>=47) return 2;
        // if(pos.x>=1247&&pos.x<=1937&&pos.y<=536&&pos.y>=47) return 3;
        if(pos.x<=(Screen.width/2)&&pos.y>=(Screen.height/2)) return 0;
        if(pos.x>=(Screen.width/2)&&pos.y>=(Screen.height/2)) return 1;
        if(pos.x<=(Screen.width/2)&&pos.y<=(Screen.height/2)) return 2;
        if(pos.x>=(Screen.width/2)&&pos.y<=(Screen.height/2)) return 3;
        return 4;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print(Screen.width);
            print(Screen.height);
            int Pos=GetMousePos(Input.mousePosition);
            // print(Input.mousePosition.x);
            // print(Input.mousePosition.y);
            if(Pos==4) return;
            print(Pos);
            if(cover[Pos]) return;
            cover[Pos]=true;
            GetComponent<Window_Random>().cover[Pos]=true;
            if(GetComponent<Window_Random>().flag[Pos])
            {
                GetComponent<Window_Random>().count--;
                GetComponent<Window_Random>().Win[Pos].GetComponent<SpriteRenderer>().enabled=false;
            }
            GetComponent<Window_Random>().flag[Pos]=false;
            cl[Pos].GetComponent<SpriteRenderer>().enabled=true;
            if(LstPos!=-1&&!cover[LstPos]) return;
            if(LstPos!=-1)
            {
                cover[LstPos]=false;
                GetComponent<Window_Random>().cover[LstPos]=false;
                cl[LstPos].GetComponent<SpriteRenderer>().enabled=false;
            }
            LstPos=Pos;
        }

        
    }
}
