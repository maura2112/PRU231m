using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text highScoresText;
    public Text scoreText;
    public static int score;
    public static int highScore;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HiScore");
        }
    }
    void Update()
    {
        if (score > highScore) 
        {
            highScore = score;
            PlayerPrefs.SetInt("HiScore", highScore);
        }
        scoreText.text = "Score: " +  Mathf.Round(score);
    }

    public void AddScore(int points)
    {
        score+=points;
    }
}
