using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float enemySpeed;
    public GameObject enemySprite;
    
    private bool canFlip = true;
    private bool facingRight = false;
    private float faceTime = 5f;
    private float nextFlip = 0f;

    public float aggroTime;
    private float startAggro;
    private bool aggroed;
    private Rigidbody2D enemyRB;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFlip)
        {
            if (Random.Range(0, 10) >= 6) flipFace();
            nextFlip = Time.time + faceTime; 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (facingRight && other.transform.position.x < transform.position.x)
            {
                flipFace();
            } else if (!facingRight && other.transform.position.x > transform.position.x)
            {
                flipFace();
            }

            canFlip = false;
            aggroed = true;
            startAggro = Time.time + aggroTime;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (startAggro < Time.time)
            {
                if(!facingRight) enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
            } else enemyRB.AddForce(new Vector2(1,0) * enemySpeed);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canFlip = true;
            aggroed = false; 
            enemyRB.velocity = new Vector2(0f,0f);
        }
    }

    void flipFace()
    {
        if (!canFlip) return;

        transform.Rotate(0f, 180f, 0f);
        facingRight = !facingRight;
    }
}
