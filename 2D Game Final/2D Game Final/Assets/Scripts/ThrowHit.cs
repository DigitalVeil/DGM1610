using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHit : MonoBehaviour
{
    public float objDamage;

    private ThrowController thisTC;

    public GameObject hitEffect;

    void Awake()
    {
        thisTC = GetComponentInParent<ThrowController>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hittable"))
        {
            thisTC.removeForce();
            Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "Enemy")
            {
                EnemyHP damageEnemy = other.gameObject.GetComponent<EnemyHP>();
                damageEnemy.inflictDamage(objDamage); 
            }
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hittable"))
        {
            thisTC.removeForce();
            Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
