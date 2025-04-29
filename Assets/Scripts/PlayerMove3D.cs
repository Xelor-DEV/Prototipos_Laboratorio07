using UnityEngine;

public class PlayerMove3D : BasePlayerController, IMoveable
{
    public void Move(Vector2 direction)
    {
        myRigidBody.linearVelocity = new Vector3(direction.x * speed, myRigidBody.linearVelocity.y, direction.y * speed);
    }
}