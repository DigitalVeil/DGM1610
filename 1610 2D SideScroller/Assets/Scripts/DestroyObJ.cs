using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObJ : MonoBehaviour
{
    
        public float activeTime;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, activeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
