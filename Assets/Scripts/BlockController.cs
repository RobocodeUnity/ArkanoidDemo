using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Score++;
        Debug.Log("poof");
        Destroy(gameObject);
    }
}
