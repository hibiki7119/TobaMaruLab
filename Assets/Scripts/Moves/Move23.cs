﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move23 : MonoBehaviour
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
            SceneManager.LoadScene("24");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("22");
        }
    }
}
