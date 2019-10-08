using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Star_Controller : MonoBehaviour
{
    float NowT,LstT;
    bool flagPhase1=false;
    bool flagPhase2=true;
    bool flagPhase3=false;
    bool wintime=false;
    public GameObject Player;
    public Text Win;
    bool Died=false;
    void Start()
    {
        NowT=LstT=Time.fixedTime;
        GameObject.Find("BackGround").GetComponent<Star_MoveDown>().enabled=true;
        GameObject.Find("God").GetComponent<Star_MoveController>().enabled=true;
    }
    void Update()
    {
        if(Player==null)
        {
            Died=true;
            GameObject.Find("BackGround").GetComponent<Star_MoveDown>().enabled=false;
            return;
        }
        NowT=Time.fixedTime;
        if(NowT-LstT>=3.0f&&!flagPhase1)
        {
            GetComponent<Star_RandomSpikeBall>().enabled=true;
            flagPhase1=true;
            flagPhase2=false;
            LstT=NowT;
        }
        if(NowT-LstT>=10.0f&&!flagPhase2)
        {
            GetComponent<Star_RandomSpikeBall>().enabled=false;
            flagPhase2=true;
            LstT=NowT;
        }
        if(NowT-LstT>=3.0f&&flagPhase2&&!flagPhase3&&!wintime)
        {
            GetComponent<Star_Phase2>().enabled=true;
            flagPhase3=true;
            LstT=NowT;
        }
        if(NowT-LstT>=7.0f&&flagPhase3)
        {
            StartCoroutine(hehehe());
            flagPhase3=false;
            wintime=true;
            LstT=NowT;
        }
        if(wintime&&NowT-LstT>=10.0f)
        {
            GameObject.Find("Shooter").GetComponent<Star_Shoot>().enabled=false;
            GameObject.Find("Shooter1").GetComponent<Star_Shoot>().enabled=false;
            GameObject.Find("Shooter2").GetComponent<Star_Shoot>().enabled=false;
            GameObject.Find("Shooter3").GetComponent<Star_Shoot>().enabled=false;
            GameObject.Find("BackGround").GetComponent<Star_MoveDown>().enabled=false;
            StartCoroutine(YouWin());
        }
    }
    IEnumerator hehehe()
    {
        GameObject.Find("Shooter").GetComponent<Star_Shoot>().enabled=true;
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Shooter1").GetComponent<Star_Shoot>().enabled=true;
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Shooter2").GetComponent<Star_Shoot>().enabled=true;
        yield return new WaitForSeconds(0.5f);
        GameObject.Find("Shooter3").GetComponent<Star_Shoot>().enabled=true;
    }
    IEnumerator YouWin()
    {
        yield return new WaitForSeconds(4.0f);
        if(!Died) Win.enabled=true;
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("movie");
    }
}
