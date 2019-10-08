using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DodgeBall : MonoBehaviour
{
    public static bool winwin = false;
    IEnumerator OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            GameObject text = GameObject.Find("Text2");
            text.GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene("Tutorial_Dodge");
        }
    }
}
