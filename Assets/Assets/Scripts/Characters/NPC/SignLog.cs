using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignLog : MonoBehaviour
{
    public TextMeshProUGUI signLog;
    private void Start()
    {
        signLog.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (signLog.gameObject.activeSelf == true)
        {
            ChangeTheLog();
        }
        else
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
    private void ChangeTheLog()
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
