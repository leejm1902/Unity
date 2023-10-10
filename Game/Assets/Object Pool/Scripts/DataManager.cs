using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private int score;
    private int currentScore;
    
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int CurrentScore
    {
        get { return currentScore; }
        set { currentScore = value; }
    }

    public static DataManager instance;

    private void Awake()
    {
        Load();

        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("SCORE", score);
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("SCORE");
    }

}
