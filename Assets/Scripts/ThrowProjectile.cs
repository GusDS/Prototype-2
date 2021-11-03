using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowProjectile : MonoBehaviour
{
    public DebugMe debugMe;
    public GameObject projectilePrefab;
    public float mouseSpeed = 100f;
    public float keysSpeed = 100f;
    private TimeMgm timeMgmScript;

    void Start()
    {
        timeMgmScript = GameObject.Find("TimeText").GetComponent<TimeMgm>();
    }

    void Update()
    {
        // Launch projectile from player's hand
        if (!timeMgmScript.timeOut)
        {
            if (Input.GetAxis("Mouse X") != 0)
            {
                transform.Rotate(Vector3.up * Mathf.Sign(Input.GetAxis("Mouse X") * Time.deltaTime * mouseSpeed));
            }
            if (Input.GetKey(KeyCode.G)) transform.Rotate(-Vector3.up * Time.deltaTime * keysSpeed);
            if (Input.GetKey(KeyCode.H)) transform.Rotate(Vector3.up * Time.deltaTime * keysSpeed);

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button0)) // Input.GetButtonDown -- se puede remapear
            {
                Instantiate(projectilePrefab, transform.position, transform.rotation);
            }
        }

    }
}
