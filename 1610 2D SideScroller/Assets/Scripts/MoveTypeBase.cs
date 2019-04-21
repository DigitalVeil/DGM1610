using UnityEngine;

public abstract class MoveTypeBase :ScriptableObject
{
    public abstract Vector3 Move(CharacterController controller, Vector3 position);
}
