using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledController : MonoBehaviour
{
    public float speed = 10f;
    public float xRangeMin = -8f; // -20f;
    public float xRangeMax = 4.6f; // 20f;
    public float zRangeMin = 4f; // -1f;
    public float zRangeMax = 4f; // 16f;
    private float horizontalInput;
    private float verticalInput;
/*    public GameObject projectilePrefab;
    private Vector3 projectileOffset = new Vector3(0.9f, 1.9f, 0.7f);
*/
    void Start()
    {

    }

    void Update()
    {
        // Player Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            if (transform.position.x < xRangeMin) transform.position = new Vector3(xRangeMin, transform.position.y, transform.position.z);
            if (transform.position.x > xRangeMax) transform.position = new Vector3(xRangeMax, transform.position.y, transform.position.z);
        }
        if (verticalInput != 0)
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
            if (transform.position.z < zRangeMin) transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
            if (transform.position.z > zRangeMax) transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }

/*        // Launch projectile from player
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button0)) // Input.GetButtonDown -- se puede remapear
        {
            Instantiate(projectilePrefab, transform.position + projectileOffset, projectilePrefab.transform.rotation);
        }*/
    }
}
