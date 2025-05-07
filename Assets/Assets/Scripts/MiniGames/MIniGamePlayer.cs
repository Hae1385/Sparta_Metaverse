using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody;

    public float flapForce = 6.0f;
    public float forwardSpeed = 3.0f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlab = false;

    public bool godMode = false;

    MiniGameManager miniGameManager = null;

    // Start is called before the first frame update
    void Start()
    {
            miniGameManager = MiniGameManager.Instance;

        Debug.Log("MiniGamePlayer " +miniGameManager );

            animator = GetComponentInChildren<Animator>();
            _rigidbody = GetComponent<Rigidbody2D>();

            if (animator == null)
                Debug.LogError("Not Founded Animator");

            if (_rigidbody == null)
                Debug.LogError("Not Founded Rigidbody");
        
    }

    // Update is called once per frame
    void Update()  //게임오버시 입력 및 게임오버가 아닐시 Flab작동
    {
        if (isDead)
        {
            if (deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    miniGameManager.BackToMain();
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    miniGameManager.RestartGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                isFlab = true;
            }
        }

    }

    private void FixedUpdate() 
    {
        if (isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlab)
        {
            velocity.y += flapForce;
            isFlab = false;
        }

        _rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (godMode) return;

        if (isDead) return;

        isDead = true;
        deathCooldown = 1f;

        animator.SetInteger("IsDie", 1);

        

        if (miniGameManager == null)
            Debug.Log("miniGameManager is Null");

        else
            miniGameManager.GameOver();

    }
}
