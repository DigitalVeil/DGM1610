using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu] 
public class ForceMoveType : MoveTypeBase {
	
	public float ForceValue = 1;
	public override Vector3 Move(CharacterController controller, Vector3 position)
	{
		position.y += ForceValue; 
		return position; 
	}


}
