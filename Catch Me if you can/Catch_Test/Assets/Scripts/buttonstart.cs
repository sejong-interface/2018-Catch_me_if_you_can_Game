﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonstart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}



    public void startgame()
    {
        SceneManager.LoadScene("stage-1");
    }



    // Update is called once per frame
    void Update () {
		
	}
}
