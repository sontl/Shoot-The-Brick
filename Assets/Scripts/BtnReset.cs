﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnReset : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("Level 1");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
