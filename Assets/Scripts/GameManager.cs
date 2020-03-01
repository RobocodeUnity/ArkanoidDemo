using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winImage;
    public Text textScore;
    public static int Score;
    void Start()
    {
        Score = 0;
        winImage.SetActive(false);
    }
    void Update()
    {
        textScore.text = "Score: " + Score;
        if (Score >= 13)
        {
            winImage.SetActive(true);
        }
    }
    public void ResetLevel()
    {
        Application.LoadLevel("SampleScene");
    }
}
