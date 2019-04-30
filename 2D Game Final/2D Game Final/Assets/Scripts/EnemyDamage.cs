using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    public float damageInt;
    public float knockBackForce;

    private float damageRate;

    void Start(){
        damageRate = 1.5f;
    }

    void Update(){

    }

    void OnTriggerStay2D(Collider2D other){
        if(other.tag=="Player" && damageRate<Time.time){
            PlayerHP playerHealth = other.gameObject.GetComponent<PlayerHP>();
            playerHealth.damageTaken(damage);
            damageRate = Time.time + damageInt;

            knockBack(other.transform);
        }
    }

    void knockBack(Transform knockedObject){
        Vector2 knockDirection = new Vector2(0, (knockedObject.position.y - transform.position.y)).normalized;
        knockDirection *= knockBackForce;
        Rigidbody2D knockRB = knockedObject.gameObject.GetComponent<Rigidbody2D>();
        knockRB.velocity = Vector2.zero;
        knockRB.AddForce(knockDirection, ForceMode2D.Impulse); 
    }
}
