using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundClick : MonoBehaviour
{
    public DebugMe debugMe;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Clicki");
        // debugMe.Show("ray.origin", ray.origin.ToString());
    }

}
