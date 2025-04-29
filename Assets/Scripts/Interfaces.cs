using UnityEngine;

public interface IMoveable
{
    void Move(Vector2 direction);
}

public interface IAttackable
{
    void Attack(Vector2 position);
}