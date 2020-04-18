using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeRespawn = 2f;
    private float timeCoolDown = -10f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeCoolDown + timeRespawn <= Time.time) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeCoolDown = Time.time;
            }
        }
    }
}
