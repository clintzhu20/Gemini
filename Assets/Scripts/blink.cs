using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class blink : MonoBehaviour
{
    public Text start_text;
    void Update()
    {
        StartCoroutine(Blink());
        StartCoroutine(Blink2());
    }

    IEnumerator Blink()
    {
        yield return new WaitForSeconds(1.0f);
        start_text.text = "";
    }

    IEnumerator Blink2()
    {
        yield return new WaitForSeconds(1.0f);
        start_text.text = "Click To Start";
    }
}
