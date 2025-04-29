using UnityEngine;

public class PlayerMove2D : BasePlayerController, IMoveable
{
    public void Move(Vector2 direction)
    {
        myRigidBody.linearVelocity = new Vector3(direction.x * speed, direction.y * speed, myRigidBody.linearVelocity.z);
    }
}