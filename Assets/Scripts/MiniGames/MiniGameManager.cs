using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager miniGameManager;

    private int currentScore = 0;

    MiniUIManager miniuiManager;
    public MiniUIManager MiniUIManager { get { return miniuiManager; } }

    public static MiniGameManager Instance { get { return miniGameManager; } }

    private void Awake()
    {
        miniGameManager = this;
        miniuiManager = FindObjectOfType<MiniUIManager>();
    }

    private void Start()
    {
        miniuiManager.UdateScore(0, miniuiManager.bestScore);
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        miniuiManager.SetRestart();
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Score: " + currentScore);
        miniuiManager.UdateScore(currentScore, miniuiManager.bestScore);
    }
}
