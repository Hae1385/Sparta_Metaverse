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
        enterTheMiniGame.gameObject.SetActive(false); //��ȭ ��Ȱ��ȭ
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterTheMiniGame.gameObject.SetActive(true);  //�÷��̾ �ڽ� �ݶ��̴� �ȿ� ������ ��ȭâ �ѱ�
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterTheMiniGame.gameObject.SetActive(false); //�÷��̾ �ڽ� �ݶ��̴� �ȿ� ���ٸ� ��ȭâ ����
        }

    }
}
