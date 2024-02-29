using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager01 : MonoBehaviour
{ 
    //demo
    public UnityEngine.Vector2 MoveInput;

    //demo
    public void OnMove(InputValue input)
    {
        MoveInput = input.Get<UnityEngine.Vector2>();
    }
}
