using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Plot_Word2 : MonoBehaviour
{
    IEnumerator OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            GameObject plot = GameObject.Find("Text3");
            plot.GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(5.0f);
            plot.GetComponent<Text>().enabled = false;
        }
    }
}
