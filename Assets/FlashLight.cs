using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject flashlight;
    // Use this for initialization
    void Start()
    {
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        FlashlightToggle();
    }

    void FlashlightToggle()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            flashlight.SetActive(false);
        }
    }
}
