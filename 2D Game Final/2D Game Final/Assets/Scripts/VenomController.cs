using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenomController : MonoBehaviour
{
    public float venomSpeed; 
    private Rigidbody2D venomRB;

    void Awake()
    {
        venomRB = GetComponent<Rigidbody2D>();
        if(transform.localRotation.z > 0)
        
            venomRB.AddForce(new Vector2(1,0) * venomSpeed, ForceMode2D.Impulse);
        
        else venomRB.AddForce(new Vector2(-1,0) * venomSpeed, ForceMode2D.Impulse);
    }

    public void removeForce()
    {
        venomRB.velocity = new Vector2(0,0);
    }
}
