using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{


	public bool CanWalk = true;
	public int Number;
	public string Password; 
		
	private void Update () 
	{
		if (!CanWalk)
		{
			
		}

		if (Number >= 10)
		{
			print("S Rank!!!!");
		}

		if (Password == "Dreamless")
		{
			print("Correct!");
		}
	}
}
