﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move45 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("46");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("44");
        }
    }
}
