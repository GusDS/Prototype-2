using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    //public Text scoreText;
    //private int scoreCounter = -1;
    private ScoreMgm scoreMgmScript;

    void Start()
    {
        scoreMgmScript = GameObject.Find("ScoreText").GetComponent<ScoreMgm>();
//        IncreaseScore();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreMgmScript.scoreCounter += 1;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

/*    public void IncreaseScore()
    {
        scoreCounter += 1;
        scoreText.text = "SCORE: " + scoreCounter;
    }
*/
}
