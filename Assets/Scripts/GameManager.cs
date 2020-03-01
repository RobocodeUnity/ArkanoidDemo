using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winImage;
    public GameObject reloadButton;
    public Text textScore;
    public static int Score;
    void Start()
    {
        reloadButton.SetActive(false);
        Score = 0;
        winImage.SetActive(false);
    }
    void Update()
    {
        textScore.text = "Score: " + Score;
        if (Score >= 13)
        {
            reloadButton.SetActive(true);
            winImage.SetActive(true);
        }
    }
    public void ResetLevel()
    {
        Application.LoadLevel("SampleScene");
    }
}
