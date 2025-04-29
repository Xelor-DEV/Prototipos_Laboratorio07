using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private GameObject PlayerController;

    private IMoveable _characterMovement;
    private IAttackable _characterAttack;

    //private IAttackable _characterAttack;

    private void Awake()
    {
        _characterMovement = PlayerController.GetComponent<IMoveable>();
        _characterAttack = PlayerController.GetComponent<IAttackable>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        _characterMovement.Move(context.ReadValue<Vector2>());
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());

        Vector2 pos = context.ReadValue<Vector2>();
        _characterAttack.Attack(pos);
    }

    //public void OnAttack(InputAction.CallbackContext context)
    //{
    //    //Debug.Log(context.phase);

    //}
}