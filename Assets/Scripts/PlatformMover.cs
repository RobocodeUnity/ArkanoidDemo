using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Vector3 plaftormPosition;
    
    void Start()
    {
       
    }

    void Update()
    { 
        plaftormPosition.x += Input.GetAxis("Horizontal"); // (10,0,0);
        gameObject.transform.position = plaftormPosition;
        Debug.Log(Input.GetAxis("Horizontal"));
    }
}
