using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class plot_word1 : MonoBehaviour
{
   IEnumerator OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            GameObject text = GameObject.Find("Text");
            text.GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(3.0f);
            text.GetComponent<Text>().enabled = false;
        }
    }
}
