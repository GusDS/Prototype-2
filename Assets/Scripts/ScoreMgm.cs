using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMgm : MonoBehaviour
{
    public int scoreCounter = 0;
    private Text scoreText;

    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    private void Update()
    {
        if (Time.time >= 3) scoreText.text = "SCORE: " + scoreCounter.ToString();
    }
}
