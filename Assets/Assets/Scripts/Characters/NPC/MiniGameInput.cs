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

    private void Update()  //미니게임 입장 과정
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (CanEnterMiniGame()) //미니게임의 대화창이 켜져있는지 판단
            {
                EnterMiniGame(); //미니게임 입장
            }
        }
    }

    private bool CanEnterMiniGame() //미니게임의 대화창이 켜져있는지 판단
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

    private void EnterMiniGame()  //미니게임 입장
    {
        Debug.Log("EnterMiniGame");
        SceneManager.LoadScene(1);
    }
}
