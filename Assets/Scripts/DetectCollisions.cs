using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private ScoreMgm scoreMgmScript;

    void Start()
    {
        scoreMgmScript = GameObject.Find("ScoreText").GetComponent<ScoreMgm>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreMgmScript.scoreCounter += 1;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
