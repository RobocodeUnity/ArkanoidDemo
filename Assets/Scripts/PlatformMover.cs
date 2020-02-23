using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Vector3 plaftormPosition;
    public int boundary;
    void Start()
    {
        boundary = 8;
    }

    void Update()
    {


        plaftormPosition.x += Input.GetAxis("Horizontal");
        if (plaftormPosition.x < -boundary)
        {
            plaftormPosition = new Vector3(-boundary, plaftormPosition.y, plaftormPosition.z);
        }
        if (plaftormPosition.x > boundary)
        {
            plaftormPosition = new Vector3(boundary, plaftormPosition.y, plaftormPosition.z);
        }
        gameObject.transform.position = plaftormPosition;

    }

}
