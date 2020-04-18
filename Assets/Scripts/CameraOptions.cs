using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOptions : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;
    private bool follow;

    private Vector3 cameraTop = new Vector3(0, 35, 7.5f); // (0, 25, 7.5f);
    private Vector3 cameraTopRotation = new Vector3(90, 0, 0);

    private Vector3 cameraBack = new Vector3(0, 4.6f, -2.5f);
    private Vector3 cameraBackRotation = new Vector3(13, 0, 0);

    private Vector3 cameraMovie = new Vector3(-2.3f, 1.2f, 15);
    private Vector3 cameraMovieRotation = new Vector3(0, -208, 0);

    void Start()
    {
        cameraOffset = cameraTop;
        transform.rotation = Quaternion.Euler(cameraTopRotation);
        follow = false;
    }

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.F1)) {
            cameraOffset = cameraTop;
            transform.position = cameraOffset;
            transform.rotation = Quaternion.Euler(cameraTopRotation);
            follow = false;
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            cameraOffset = cameraBack;
            transform.rotation = Quaternion.Euler(cameraBackRotation);
            follow = true;
        }
        else if (Input.GetKey(KeyCode.F3))
        {
            cameraOffset = cameraMovie;
            transform.rotation = Quaternion.Euler(cameraMovieRotation);
            follow = true;
        }

        if (follow) {
            transform.position = player.transform.position + cameraOffset;
        }
    }
}
