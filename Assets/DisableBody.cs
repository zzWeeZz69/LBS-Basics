using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBody : MonoBehaviour
{
    [SerializeField]
    GameObject Body;

    void Start()
    {
        Body.SetActive(false);
    }

    
    void Update()
    {

    }
}
