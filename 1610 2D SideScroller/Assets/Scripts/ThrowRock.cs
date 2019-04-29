using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRock : MonoBehaviour
{
    public Transform throwPoint;
    public GameObject RockPrefab;
    private float fireRate = 0.5f;
    private float nextRock = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time > nextRock)
        {
            nextRock = Time.time+fireRate;
            
        }
        
        Instantiate(RockPrefab, throwPoint.position, throwPoint.rotation);
        
    }
}
