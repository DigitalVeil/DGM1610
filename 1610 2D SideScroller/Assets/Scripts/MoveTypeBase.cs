using UnityEngine;

public abstract class MoveTypeBase :ScriptableObject
{
    public abstract Vector2 Move(CharacterController controller, Vector2 position);
}
