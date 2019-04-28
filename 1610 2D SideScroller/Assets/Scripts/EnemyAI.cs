using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
   public int health = 100;
   public GameObject deathEffect;


   public void DamageTaken(int damage)
   {
      health -= damage;

      if (health <= 0)
      {
         Death();
      }
   }

   void Death()
   {
      Instantiate(deathEffect, transform.position, Quaternion.identity);
      Destroy(gameObject);
   }
}
