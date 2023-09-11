using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        // New 'WASD' player input actions (no more if statements)
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        // normalizes diagonal movement so it runs at same speed
        inputVector = inputVector.normalized;

        Debug.Log(inputVector);
        return inputVector;
    }
}
