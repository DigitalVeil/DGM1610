using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{

	public UnityEvent OnEvent, OffEvent;
	public bool OnBool = true;
	public int Number;
	public string Password; 
		
	private void Update () 
	{
		if (OnBool)
		{
			OnEvent.Invoke();
		}
		else
		{
			OffEvent.Invoke();
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
