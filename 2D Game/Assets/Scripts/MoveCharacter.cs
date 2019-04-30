using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

private CharacterController controller;
private Rigidbody otterBody;
private Vector3 position;

public List<MoveTypeBase> MovementOptions;
public float walkSpeed = 2f;

private void Start()
{
    controller = GetComponent<CharacterController>();
    otterBody = GetComponent<Rigidbody>();
}

private void Update()
{
    foreach (var movement in MovementOptions)
    {
        position = movement.Move(controller, position);
    }

    controller.Move(position);
}

void DetectMovement()
{
    otterBody.velocity = new Vector3(
        Input.GetAxisRaw(Axis.HorizontalAxis) * -walkSpeed,
        otterBody.velocity.y,
        Input.GetAxisRaw(Axis.VerticalAxis));
}

private void FixedUpdate()
{
    DetectMovement();
}

void RotatePlayer()
{
    if (Input.GetAxisRaw(Axis.HorizontalAxis) > 0)
    {
        transform.Rotate(0, 180, 0);
    } 
}
}