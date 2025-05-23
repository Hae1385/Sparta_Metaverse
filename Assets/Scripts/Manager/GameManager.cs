using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerController player {  get; private set; }

    private ResourceController resourceController;

    private void Awake()
    {
        if (Instance != null)
        {
            Instance = this;

            player = FindObjectOfType<PlayerController>();
            player.Init(this);

            resourceController = GetComponent<ResourceController>();
        }
    }


}
