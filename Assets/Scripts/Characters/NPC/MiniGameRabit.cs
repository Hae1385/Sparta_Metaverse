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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rabitLog.gameObject.SetActive(true);
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
