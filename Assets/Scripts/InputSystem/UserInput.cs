using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;

    public Vector2 MoveInput { get; private set; }
    public Vector2 BoostInput { get; private set; }
    //public bool MenuOpenCloseInput { get; private set; }

    private PlayerInput _playerInput;

    private InputAction _moveAction;
    private InputAction _boostAction;
    //private InputAction _menuOpenCloseAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();

        SetUpInputActions();
    }

    private void Update()
    {
        UpdateInputs();
    }

    void SetUpInputActions()
    {
        _moveAction = _playerInput.actions["Move"];
        _boostAction = _playerInput.actions["Boost"];
        //_menuOpenCloseAction = _touch.actions["MenuOpenCloseAction"];
    }

    void UpdateInputs()
    {
        MoveInput = _moveAction.ReadValue<Vector2>();
        BoostInput = _boostAction.ReadValue<Vector2>();
        //MenuOpenCloseInput = _menuOpenCloseAction.WasPressedThisFrame();
   }
}
