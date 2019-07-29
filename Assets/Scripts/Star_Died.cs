using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star_Died : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        if(Player==null)
        {
            GetComponent<Text>().enabled=true;
        }
    }
}
