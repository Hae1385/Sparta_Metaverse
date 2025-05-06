using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI bestScoreText;

    public int bestScore = 0;

    public int BestScore { get => bestScore; }

    private const string BestScoreKey = "BestScore";
    

    // Start is called before the first frame update
    void Start()
    {
        if (gameOverText == null)
            Debug.LogError("restart text is null");

        if (scoreText == null)
            Debug.LogError("score text is null");

        gameOverText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        gameOverText.gameObject.SetActive(true);
    }

    public void UdateScore(int score, int bestScore)
    {
        scoreText.text = score.ToString();

        if(bestScore < score)
        {
            bestScore = score;

            PlayerPrefs.SetInt(BestScoreKey, bestScore);
        }
    }

    

}
