using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameHouse : MonoBehaviour
{
    public string miniGameSceneName = "MiniGameScene";
    public TextMeshProUGUI enterTheMiniGame;
    MiniGameInput MiniGameInput;

    public MiniGameInput miniGameInput { get { return miniGameInput; } }

    private void Start()
    {
        enterTheMiniGame.gameObject.SetActive(false); //대화 비활성화
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterTheMiniGame.gameObject.SetActive(true);  //플레이어가 박스 콜라이더 안에 있으면 대화창 켜기
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterTheMiniGame.gameObject.SetActive(false); //플레이어가 박스 콜라이더 안에 없다면 대화창 끄기
        }

    }
}
