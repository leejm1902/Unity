using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text currentScoreText;

    private void Start()
    {
        scoreText.text = "Best Score : " + DataManager.instance.Score;
    }

    public void IncreaseScore()
    {
        DataManager.instance.CurrentScore += 100;

        if(PlayerPrefs.GetInt("SCORE") <= DataManager.instance.CurrentScore)
        {
            DataManager.instance.Score = DataManager.instance.CurrentScore;
            scoreText.text = "Best Score : " + DataManager.instance.Score;
        }

        currentScoreText.text = "Current Score : " + DataManager.instance.CurrentScore;

        DataManager.instance.Save();
    }
}
