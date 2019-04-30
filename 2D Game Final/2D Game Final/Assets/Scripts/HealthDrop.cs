using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{

    public float healGain; 
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHP currentHP = other.gameObject.GetComponent<PlayerHP>();
            currentHP.addHealth(healGain);
            Destroy(gameObject);
        }
    }
}
