using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    public float healValue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            PlayerHP theHP = other.gameObject.GetComponent<PlayerHP>();
            theHP.addHealth(healValue); 
            Destroy(gameObject);
        }
    }
}
