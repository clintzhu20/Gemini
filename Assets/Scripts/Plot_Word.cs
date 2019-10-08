using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Plot_Word : MonoBehaviour
{
    IEnumerator OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            GameObject plot = GameObject.Find("Text2");
            plot.GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene("Tutorial_Window");
        }
    }
}
