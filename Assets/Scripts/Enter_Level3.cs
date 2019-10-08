using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enter_Level3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player" && DodgeBall.winwin)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
