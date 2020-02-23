using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textScore;
    public static int Score;
    void Start()
    {
 
    }
    void Update()
    {
        textScore.text = "Score: " + Score;
    }
}
