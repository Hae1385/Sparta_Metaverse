using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameInput : MonoBehaviour
{
    public string miniGameSceneName = "MiniGameScene";
    public TextMeshProUGUI enterTheMiniGame;

    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CanEnterMiniGame()) // ������ Ȯ�� (��: UI�� ���� ���� ��)
            {
                EnterMiniGame();
            }
        }
    }

    private bool CanEnterMiniGame()
    {
        // ����: ��ȣ�ۿ� ���� ������ �� �ְ�, UI�� ���� ���� �� ��
        if (enterTheMiniGame.gameObject == true)
            return true;
        else return false;

    }

    private void EnterMiniGame()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            SceneManager.LoadScene(miniGameSceneName);
        else return;
    }
}
