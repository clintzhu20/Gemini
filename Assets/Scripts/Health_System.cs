using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health_System : MonoBehaviour
{
    public Text Losetext;
    public int health = 5, MaxHP = 5;
    RectTransform tmp;
    void Start()
    {
        tmp = GameObject.Find("Blood").GetComponent<RectTransform>();
    }
    void Update()
    {
        tmp.sizeDelta = new Vector2(100 * health / MaxHP, 10);
        tmp.anchoredPosition = new Vector2(50 * health / MaxHP + 2, -9);
        //if(health<=0) Destroy(this.gameObject);
        if (health == 0)
        {
            GameObject shoot = GameObject.Find("ShootController");
            shoot.GetComponent<Ball_Appear>().enabled = false;
            Destroy(this.gameObject);
            Losetext.text = "Oh NO!";
        }
    }
    
}
