using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : BasePlayerController, IMoveable, IAttackable
{


    protected override void Start()
    {
        base.Start();

        Debug.Log("Child Start");
    }

    public void Move(Vector2 direction)
    {
        Debug.Log("Move from " + this.name);
    }

    public void Attack(Vector2 position)
    {
        Debug.Log("Attack from " + this.name);
    }
}
