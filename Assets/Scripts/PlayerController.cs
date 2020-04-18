using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject particle;
    public DebugMe debugMe;
    //public float speed = 10f;
    //public float xRangeMin = -20f;
    //public float xRangeMax = 20f;
    //public float zRangeMin = -1f;
    //public float zRangeMax = 16f;
    //private float horizontalInput;
    //private float verticalInput;
    public GameObject projectilePrefab;
    public Vector3 projectileOffset = new Vector3(0.9f, 1.9f, 0.7f);
    private Vector3 crossPoint;
    private TimeMgm timeMgmScript;

    void Start()
    {
        timeMgmScript = GameObject.Find("TimeText").GetComponent<TimeMgm>();
    }

    void Update()
    {
        /*        // Player Movement
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
        */

        //crossPoint = transform.position + projectileOffset + (Vector3.forward * 100);
        //Debug.DrawLine(transform.position, crossPoint);

/*        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
                Instantiate(projectilePrefab, ray.origin, projectilePrefab.transform.rotation);
            debugMe.Show("ray.origin", ray.origin.ToString());
            debugMe.Show("ray.direction", ray.direction.ToString());
            debugMe.Show("worldpoint", Camera.main.ScreenToWorldPoint(Input.mousePosition).ToString());
        }
*/
        // Launch projectile from player
        if (!timeMgmScript.timeOut)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //RaycastHit hit;
                //if (Physics.Raycast(ray, out hit))
                //{
                //    Debug.DrawLine(transform.position, hit.point);

                //}
                // projectilePrefab.transform.LookAt(Input.mousePosition);
                // projectilePrefab.transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                // Instantiate(projectilePrefab, transform.position + projectileOffset, projectilePrefab.transform.rotation);
                // Input.mousePosition /* V3 destino */ - (transform.position + projectileOffset) /* V3 origen */, // resta de vectores da nuevo vector con dirección origen>destino
            }
            else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl)) // Input.GetButtonDown -- se puede remapear
            {
                Instantiate(projectilePrefab, transform.position + projectileOffset, projectilePrefab.transform.rotation);
            }
        }
    }
}
