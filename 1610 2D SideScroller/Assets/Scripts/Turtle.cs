using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : Reptile {

	public int ScaleCount = 100;
	public float FallSpeed = 6.7f;
	public FloatData armor;  
	public bool CanFall = true; 
	public Color shellColor;

	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = skinColor;
		
		GetComponent<SpriteRenderer>().color = scaleColor;

		GetComponent<SpriteRenderer>().color = shellColor;

		GetComponent<SpriteRenderer>().color = eyeColor;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
