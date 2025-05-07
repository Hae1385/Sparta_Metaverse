using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameRabit : MonoBehaviour
{
    public TextMeshProUGUI rabitLog;

    private void Start()
    {
        rabitLog.gameObject.SetActive(false);  //대화 비활성화
    }

    private void Update()
    {
        if (rabitLog.gameObject.activeSelf == true) //게임 오브젝트가 있다면
        {
            ChangeTheLog(); //대화 수정
        }
        else //게임 오브젝트가 꺼지면 처음 로그로 돌아가기위한 코드
        {
            string rabitStartLog = ("Welcome to \n MiniGame House");
            rabitLog.text = rabitStartLog.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rabitLog.gameObject.SetActive(true);
        }
    }
    private void ChangeTheLog() //대화수정
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            string rabitLogfirst = ("Let's play the MiniGame!!\n Press the Space!!");
            rabitLog.text = rabitLogfirst.ToString();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rabitLog.gameObject.SetActive(false);
        }

    }
}
