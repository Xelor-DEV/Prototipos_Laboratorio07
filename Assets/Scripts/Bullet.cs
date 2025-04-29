using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float Speed;
    public Vector3 direction;

    private void FixedUpdate()
    {
        transform.position += direction * Speed * Time.fixedDeltaTime;
    }
}