using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{

    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        ballInitialForce = new Vector2(100, 300);
    }

    // Update is called once per frame
    void Update()
    {
        if(!ballIsActive)
        {
            ballPosition.x = player.transform.position.x;
            gameObject.transform.position = ballPosition;
        }

        if (Input.GetKeyDown("space"))
        {
            ballIsActive = true;
            GetComponent<Rigidbody2D>().AddForce(ballInitialForce);
            Debug.Log("SpacePressed");
        }
    }
}
