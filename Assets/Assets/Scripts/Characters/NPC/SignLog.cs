using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignLog : MonoBehaviour
{
    public TextMeshProUGUI signLog;
    private void Start()
    {
        signLog.gameObject.SetActive(false);  //대화 비활성화
    }

    private void Update()
    {
        if (signLog.gameObject.activeSelf == true) //게임 오브젝트가 있다면
        {
            ChangeTheLog();  //대화수정
        }
        else  //게임 오브젝트가 꺼지면 처음 로그로 돌아가기위한 코드
        {
            string rabitStartLog = ("Press the K!!\nNext Log!!"); 
            signLog.text = rabitStartLog.ToString(); 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            signLog.gameObject.SetActive(true);
        }
    }

    private void ChangeTheLog() //대화 수정
    {
        if (Input.GetKeyDown(KeyCode.K))  
        {
            string rabitLogfirst = ("Great job!!\nThere are MiniGame house\nup there too!!");
            signLog.text = rabitLogfirst.ToString();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            signLog.gameObject.SetActive(false);
        }

    }
}
