using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_On_touch : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Ground")
            Destroy(this.gameObject);
        if (other.gameObject.name == "player")
        {
            GameObject player = GameObject.Find("player");
            GameObject cam = GameObject.Find("Main Camera");
            cam.GetComponent<ShakeCamera>().enabled = true;
            player.GetComponent<Health_System>().health--;
            Destroy(this.gameObject);
        }
    }
}
