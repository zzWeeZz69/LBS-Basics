using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraSpeed;
    [SerializeField]
    Camera Cam;
    [SerializeField]
    GameObject Player;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Cam.transform.Rotate(Input.GetAxis("Mouse Y") * -CameraSpeed, 0, 0);
        Player.transform.Rotate(0, Input.GetAxis("Mouse X") * CameraSpeed, 0);
    }
}
