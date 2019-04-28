using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRock : MonoBehaviour
{
    public Transform throwPoint;
    public GameObject RockPrefab; 

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
        Instantiate(RockPrefab, throwPoint.position, throwPoint.rotation);
    }
}
