using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    public CharacterMovement characterMovement;
    private void Awake()
    {
        Debug.LogError($"{name} :{nameof(characterMovement)}is null!" + $"\n This class dependant on a characterMovemnet component!");
    }
    public void HandelMoveInput(InputAction.CallbackContext context)
    {
        Vector2 moveIntput = context.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveIntput.x, 0, moveIntput.y);
        if (characterMovement !=null)
        {
            characterMovement.Move(moveDirection);
        }
    }
}