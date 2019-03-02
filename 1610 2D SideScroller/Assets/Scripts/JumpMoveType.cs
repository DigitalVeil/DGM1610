using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpMoveType : MoveTypeBase { 
    private float JumpStart;
    private Vector2 position; 
    public float JumpValue = 50;
    public float JumpCount = 2;
    
    public override Vector2 Move(CharacterController controller, Vector2 position)
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
