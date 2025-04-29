using UnityEngine;

public abstract class BasePlayerController : MonoBehaviour
{
    [SerializeField] protected Rigidbody myRigidBody;
    [SerializeField] protected float speed;

    protected virtual void Start()
    {
        if (myRigidBody == null)
        {
            myRigidBody = GetComponent<Rigidbody>();
        }
    }
}
