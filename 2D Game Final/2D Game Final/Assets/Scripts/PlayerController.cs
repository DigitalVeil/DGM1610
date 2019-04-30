using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed;
    
    public LayerMask groundLayer;
    public Transform checkGround;
    public float jumpForce;

    public Transform throwPoint;
    public GameObject Rock; 
    
    private bool facingRight;
    private bool grounded = false;
    private float groundCheckCircle = 0.4f;

    private float throwRate = 0.3f;
    private float nextThrow = 0f; 
    
    private Rigidbody2D otterRB;
    private Animator otterAnim;
    

    void Start()
    {
        otterRB = GetComponent<Rigidbody2D>();
        otterAnim = GetComponent<Animator>();

        facingRight = false;
    }

    void Update()
    {
        if(grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false; 
            otterAnim.SetBool("grounded", grounded);
            otterRB.AddForce(new Vector2(0,jumpForce));
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Projectile(); 
        }
    }

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(checkGround.position, groundCheckCircle, groundLayer);
        
        otterAnim.SetBool("grounded", grounded);
        otterAnim.SetFloat("fallSpeed", otterRB.velocity.y);
        
        
        float move = Input.GetAxis("Horizontal");
        otterAnim.SetFloat("speed", Mathf.Abs(move));
        
        otterRB.velocity = new Vector2(move * runSpeed, otterRB.velocity.y);

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
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale; 
    }

    void Projectile()
    {
        if (Time.time > nextThrow)
        {
            nextThrow = Time.time + throwRate;
            if (facingRight)
            {
                Instantiate(Rock, throwPoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            } else if (!facingRight)
            {
                Instantiate(Rock, throwPoint.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
            }
        }
    }
}
