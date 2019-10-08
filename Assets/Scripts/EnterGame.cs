using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnterGame : MonoBehaviour
{
   IEnumerator OnCollisionEnter2D(Collision2D other)
    {
        if( other.gameObject.name == "player")
        {
            GameObject Plot = GameObject.Find("Text");
            Plot.GetComponent<Text>().enabled = true;
        }

        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene("Tutorial_Teddy");
    }
}
