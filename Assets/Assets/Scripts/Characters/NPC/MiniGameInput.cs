using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameInput : MonoBehaviour
{
    public string miniGameSceneName = "MiniGameScene";
    public TextMeshProUGUI enterTheMiniGame;

    private void Start()
    {
        enterTheMiniGame.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CanEnterMiniGame())
            {
                EnterMiniGame();
            }
        }
    }

    private bool CanEnterMiniGame()
    {
        if (enterTheMiniGame.gameObject.activeSelf == true)
        {
            Debug.Log("CanEnterMiniGame true");
            return true;
        }
        else 
        {
            Debug.Log("CanEnterMiniGame false");
            return false; 
        }

    }

    private void EnterMiniGame()
    {
        Debug.Log("EnterMiniGame");
        SceneManager.LoadScene(1);
    }
}
