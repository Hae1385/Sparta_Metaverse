using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameRabit : MonoBehaviour
{
    public TextMeshProUGUI rabitLog;

    private void Start()
    {
        rabitLog.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (rabitLog.gameObject.activeSelf == true)
        {
            ChangeTheLog();
        }
        else
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
    private void ChangeTheLog()
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
