using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enter_Level2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player" && GameBool.Game1 && GameBool.Game2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
