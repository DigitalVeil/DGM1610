using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController1 : MonoBehaviour
{

    public float speed;

    private Rigidbody2D playerRB;
    private Animator playerAnim;
    private bool facingRight;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();

        facingRight = true; 
    }


    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        playerAnim.SetFloat("speed", Mathf.Abs(move)); 
        
        playerRB.velocity = new Vector2(move*speed, playerRB.velocity.y);

        if (move > 0 && !facingRight)
        {
            Flip();
        } else if (move < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x = -1;
        transform.localScale = scale; 

    }
}
