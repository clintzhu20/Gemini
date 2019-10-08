using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Text Tim;
    public Text WinText;
    float NowT, LstT, LstT2;
    void Start()
    {
        NowT = LstT = LstT2 = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        int diff = 30 - (int)(NowT - LstT2);
        Tim.text = diff.ToString();
        NowT = Time.fixedTime;
        if (NowT - LstT >= 0.05f)
        {
            LstT = NowT;
        }
        if (NowT - LstT2 >= 30.0f)
        {
            GameObject text = GameObject.Find("Text");
            Tim.text = "0";
            WinText.text = "You Win!";
            GameBool.Game1 = true;
            text.GetComponent<Text>().enabled = false;
            Child.movement_speed = 0;
            move_upward.move_up_factor = 0;
        }
        if (Child.movement_speed == 0 && Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Level1");
        }

    }
}