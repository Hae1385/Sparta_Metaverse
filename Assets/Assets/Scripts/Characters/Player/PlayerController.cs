using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    private Camera camera;
    private GameManager gameManager;


    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
        camera = Camera.main;
    }

    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>();
        moveDirection = moveDirection.normalized;
    }

    

}
