using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelMgm : MonoBehaviour
{
    void Start()
    {
        Invoke("EnablePanel", 3);
    }

    void Update()
    {
    }

    void EnablePanel ()
    {
        this.GetComponent<Image>().enabled = true;
    }
}
