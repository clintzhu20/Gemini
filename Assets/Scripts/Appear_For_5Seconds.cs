using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Appear_For_5Seconds : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3.0f);
        this.gameObject.SetActive(false);
        GameObject word = GameObject.Find("Begin");
        word.GetComponent<Text>().enabled = false;
        GameObject player = GameObject.Find("player");
        player.GetComponent<Move_Controll>().enabled = true;
    }
}
