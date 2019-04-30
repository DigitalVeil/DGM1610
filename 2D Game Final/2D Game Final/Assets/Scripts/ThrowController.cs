using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowController : MonoBehaviour
{
    public float projectileSpeed; 
    private Rigidbody2D throwRB;

    void Awake()
    {
        throwRB = GetComponent<Rigidbody2D>();
        if(transform.localRotation.z > 0)
        
        throwRB.AddForce(new Vector2(-1,0) * projectileSpeed, ForceMode2D.Impulse);
        
        else throwRB.AddForce(new Vector2(1,0) * projectileSpeed, ForceMode2D.Impulse);
    }

    public void removeForce()
    {
        throwRB.velocity = new Vector2(0,0);
    }
}
