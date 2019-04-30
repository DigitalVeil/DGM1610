using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpMoveType : MoveTypeBase { 
    private float JumpStart;
    private Vector2 position; 
    public float JumpValue = 50;
    public float JumpCount = 2;
    
    public override Vector3 Move(CharacterController controller, Vector3 position)
    {    
        if (JumpCount > 1 && Input.GetKeyDown(KeyCode.Space))
        {
         
            JumpCount--;
            position.y = JumpValue * Time.deltaTime;
        }

        if (controller.isGrounded)
        {	
            JumpCount = JumpStart; 
        }

        return position; 
    }

   
}
