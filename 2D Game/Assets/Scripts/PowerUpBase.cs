using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{

	public float value = 1.0f;

	public void OnPowerUp(float addValue)
	{
		value += addValue;
	}
	
	
	
}
