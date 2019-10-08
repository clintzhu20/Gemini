using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DieOnTouch : MonoBehaviour
{
    public static bool ifTouch = false;
    void start()
    {
        ifTouch = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Air Box")
            return;
        ifTouch = true;
        Child.movement_speed = 0;
        move_upward.move_up_factor = 0;
        GameObject timer = GameObject.Find("Timer");
        GameObject Text = GameObject.Find("Text");
        Text.GetComponent<Text>().text = "Your Teddy Gets Hurt";
        timer.GetComponent<Timer>().enabled = false;
    }
}