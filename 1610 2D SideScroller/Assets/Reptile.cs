using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reptile : Animal
{
	public int ScaleCount = 100;
	public FloatData FallSpeed = 6.7f;
	public FloatData Armor = 2.0f; 
	public bool CanFall = true; 
	public Color scaleColor;

	public Color teethFangColor; 
	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = skinColor;
		
		GetComponent<SpriteRenderer>().color = scaleColor;

		GetComponent<SpriteRenderer>().color = teethFangColor;

		GetComponent<SpriteRenderer>().color = eyeColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
