﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finished = false;
    private bool started = true;

    // Use this for initialization
    void Start () {

        startTime = Time.time;

            }
	
	// Update is called once per frame
	void Update () {

        
        if (finished)
            return;
        
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        

    }

    public void start()
    {
        started = false;
        

    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

    }
}
