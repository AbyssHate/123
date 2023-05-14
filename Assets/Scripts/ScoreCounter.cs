using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScore;

    public void Update()
    {
        ScoreText.text = "Score: " + FindAnyObjectByType<Ball>().Score.ToString();
        HighScore.text = "HighScore: " + Ball.HighScore.ToString();


    }
}
