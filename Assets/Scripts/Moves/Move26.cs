﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move26 : MonoBehaviour
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
            SceneManager.LoadScene("27");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("25");
        }
    }
}
