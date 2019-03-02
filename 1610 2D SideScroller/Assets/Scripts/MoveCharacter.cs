using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

private CharacterController controller;
private Vector2 position;
public List<MoveTypeBase> MovementOptions; 

private void Start()
{
    controller = GetComponent<CharacterController>();
    
}

private void Update()
{
    foreach (var movement in MovementOptions)
    {
        position = movement.Move(controller, position);
    }

    controller.Move(position);
}
}