using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float MoveSpeed = 20f;
    
    [SerializeField]
    Rigidbody rbody;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Move;
        Move = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal") * MoveSpeed,0 , Input.GetAxis("Vertical") * MoveSpeed));
        Move.y = rbody.velocity.y;
        rbody.velocity = Move;
    }
}
