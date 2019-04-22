using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rigid;

    private bool facingRight = true;
    private bool isGrounded;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int doubleJump;
    public int extraJumps;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
        moveInput = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector3(moveInput * speed, rigid.velocity.y);

        switch (facingRight)
        {
            case false when moveInput > 0:
            case true when moveInput < 0:
                Flip();
                break;
        }
    }

    void Update()
    {
        if (isGrounded == true)
        {
            doubleJump = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && doubleJump > 0)
        {
            rigid.velocity = Vector2.up * jumpForce;
            doubleJump--;
        } else if(Input.GetKeyDown(KeyCode.Space) && doubleJump == 0 && isGrounded == true)
        {
            rigid.velocity = Vector2.up * jumpForce; 
        }
    }
    
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
    }
}
    

