using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDrop : MonoBehaviour
{
  public float healthLoss;


  void Start()
  {
    
  }

  void Update()
  {
    
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      PlayerHP currentHP = other.gameObject.GetComponent<PlayerHP>();
      currentHP.damageTaken(healthLoss);
      Destroy(gameObject);
    }
  }
}
