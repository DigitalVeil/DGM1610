using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootVenom : MonoBehaviour
{
   public GameObject Venom;
   public float shootTime;
   public int venomChance;
   public Transform expelVenom;

   private float nextShot;
   private Animator snakeAnim;

   void Start()
   {
      snakeAnim = GetComponentInChildren<Animator>();
      nextShot = 0f;
   }

   void Update()
   {
      
   }

   void OnTriggerStay2D(Collider2D other)
   {
       if (other.tag == "Player" && nextShot < Time.time)
       {
           nextShot = Time.time + shootTime;
           if (Random.Range(0, 10) >= venomChance)
           {
               Instantiate(Venom, expelVenom.position, Quaternion.identity);
               snakeAnim.SetTrigger("venomChance");
           }
       }  
   }
}
