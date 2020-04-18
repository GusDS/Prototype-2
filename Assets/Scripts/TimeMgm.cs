using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMgm : MonoBehaviour
{
    public bool timeOut = false;
    private Text timeText;
    private int timeDelay = 3;
    private int timeCounter = 0;
    private RawImage timeOutImage;

    void Start()
    {
        timeText = this.GetComponent<Text>();
        timeOutImage = GameObject.Find("TimeOutImage").GetComponent<RawImage>();
    }

    void Update()
    {
        if (Time.time >= 3)
        {
            timeCounter = Convert.ToInt32(Time.time) - timeDelay;
            if (timeCounter == 50)
            {
                timeText.color = Color.red;
            }
            if (timeCounter >= 60)
            {
                timeText.text = "TIME: 01:00";
                timeOut = true;
                timeOutImage.enabled = true;
                Time.timeScale = 0.05f;
            }
            else
            {
                timeText.text = "TIME: " + timeCounter.ToString("00:00");
            }
        }
    }
}
