﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump_to_star : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Stars");
    }
}
