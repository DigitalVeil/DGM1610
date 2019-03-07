using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSquirrel : Mammal {
	
	public bool canFall = false;
	public float flightSpeed = 3.7f; 
	
	// Use this for initialization
	void Start () {
		
		
		GetComponent<SpriteRenderer>().color = skinColor;

		GetComponent<SpriteRenderer>().color = furColor

		GetComponent<SpriteRenderer>().color = eyeColor;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
