﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacter : MonoBehaviour
{

	private CharacterController controller;
	private Vector2 position;
	private float JumpStart; 
	
	public float MoveSpeed = 5;
	public float Gravity = -9.81f;
	public float JumpValue = 50;
	public float JumpCount = 2;
	
	// Use this for initialization
	void Start ()
	{
		JumpStart = JumpCount; 
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		position.x = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
		
		if (JumpCount > 1 && Input.GetKeyDown(KeyCode.Space))
		{
			print("we jumped!");
			JumpCount--;
			position.y = JumpValue * Time.deltaTime;
		}

		if (controller.isGrounded)
		{	
			JumpCount = JumpStart; 
		}
		position.y -= Gravity * Time.deltaTime;
		controller.Move(position);
	}
}
