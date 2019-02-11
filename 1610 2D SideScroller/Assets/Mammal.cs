using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal
{

	public Color furColor;
	
	public Color noseColor; 

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().color = skinColor;
        		
        		GetComponent<SpriteRenderer>().color = furColor;
        
        		GetComponent<SpriteRenderer>().color = noseColor;
        
        		GetComponent<SpriteRenderer>().color = eyeColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
