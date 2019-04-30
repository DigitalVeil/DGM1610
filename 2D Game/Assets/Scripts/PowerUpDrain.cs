using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDrain : PowerUpBase {

	// Use this for initialization
	void Start () {
		
	}
	
	public void OnPowerDrain(float addValue)
	{
		value -= addValue;
	}

}
