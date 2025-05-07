using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MiniUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI bestScoreText;

    public int Score;
    public int bestScore = 0;

    public int BestScore { get => bestScore; }

    private const string BestScoreKey = "BestScore";
    

    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        gameOverText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        gameOverText.gameObject.SetActive(true);
    }

    public void UdateScore(int score, int bestscore)
    {
        scoreText.text = score.ToString();
        Score = score;

        bestScoreText.text = bestScore.ToString();

        if (bestScore < Score)
        {
            bestScore = Score;
            PlayerPrefs.SetInt(BestScoreKey, bestScore);
        }
    }

}
