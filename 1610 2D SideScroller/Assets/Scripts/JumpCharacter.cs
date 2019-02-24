using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacter : MonoBehaviour
{

	private CharacterController controller;
	private Vector2 position;
	public float Gravity = -9.81f;
	public float JumpValue = 50;
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			print("we jumped!");
		}
		position.y = Gravity * Time.deltaTime;
		controller.Move(position);
	}
}
