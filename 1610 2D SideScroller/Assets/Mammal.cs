using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mammal : Animal
{
	public int FurCount = 3;
	public FloatData FallSpeed = 3.2f;
	public bool CanFall = true;
	public UnityEvent Event; 
	public Color furColor;
	
	public Color noseColor; 

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().color = skinColor;
        		
        		GetComponent<SpriteRenderer>().color = furColor;
        
        		GetComponent<SpriteRenderer>().color = noseColor;
        
        		GetComponent<SpriteRenderer>().color = eyeColor;
                
                Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
