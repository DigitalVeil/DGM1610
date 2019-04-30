using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearObj : MonoBehaviour
{
    public float lifeTime; 
    
    
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

  
    void Update()
    {
        
    }
}
