using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSpawn : MonoBehaviour
{
    private bool activate = false;
    public Transform spawnLocation;
    public GameObject win;

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !activate)
        {
            activate = true;
            Instantiate(win, spawnLocation.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
