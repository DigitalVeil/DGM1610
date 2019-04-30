using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float gatorSpeed;
    private Animator gatorAnimator;

    public GameObject enemyGraphic;
    private bool canFlip = true;
    private bool facingRight = false;
    private float turnTime = 5f;
    private float nextTurnChance = 0f;

    public float aggroTime;
    private float startAggro;
    private bool aggroed;
    private Rigidbody2D gatorRB;
   
    void Start()
    {
        gatorAnimator = GetComponentInChildren<Animator>();
        gatorRB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Time.time > nextTurnChance)
        {
            if (Random.Range(0, 10) > 6) turnFace();
            nextTurnChance = Time.time + turnTime;
        }
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (facingRight && other.transform.position.x < transform.position.x)
            {
                turnFace();
            } else if (!facingRight && other.transform.position.x > transform.position.x)
            {
                turnFace();
            }
        }

        canFlip = false;
        aggroed = true;
        startAggro = Time.time + aggroTime; 
    }

  void OnTriggerStay2D(Collider2D other)
   {
       if (other.tag == "Player")
       {
           if (startAggro < Time.time)
           {
               if(!facingRight) gatorRB.AddForce((new Vector2(-1,0)* gatorSpeed));
               else gatorRB.AddForce(new Vector2(1,0)* gatorSpeed);
               gatorAnimator.SetBool("Aggro", aggroed);
           }
       }
   }

    void OnTriggerExit2D(Collider2D other)
  {
      if (other.tag == "Player")
      {
          canFlip = true;
          aggroed = false;
          gatorRB.velocity = new Vector2(0f,0f);
          gatorAnimator.SetBool("Aggro", aggroed);
      }
  }

  void turnFace()
   {
       if (!canFlip) return;
       var facingX = enemyGraphic.transform.localScale.x;
       facingX *= -1f;
       enemyGraphic.transform.localScale = new Vector3(facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);
       facingRight = !facingRight; 
   }
}
