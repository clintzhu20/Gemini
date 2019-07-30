using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieOnTouch : MonoBehaviour
{
    public static bool ifTouch = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Air Box")
            return;
        ifTouch = true;
        Child.movement_speed = 0;
        move_upward.move_up_factor = 0;
    }
}