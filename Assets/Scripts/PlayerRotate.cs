using UnityEngine;
using UnityEngine.Windows;

public class PlayerRotate : BasePlayerController, IMoveable
{
    public void Move(Vector2 direction)
    {
        Vector3 rotation = new Vector3(
            direction.y * speed * Time.deltaTime,
            direction.x * speed * Time.deltaTime,
            0f
        );

        transform.Rotate(rotation, Space.Self);
    }
}
