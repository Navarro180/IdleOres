using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;

    public static PlayerInput _playerInput;

    public Vector2 MoveInput { get; private set; }
    public Vector2 BoostInput { get; private set; }
    public bool MenuPauseInput { get; private set; }
    public bool MenuUnpauseInput { get; private set; }

    private InputAction _moveAction;
    private InputAction _boostAction;
    private InputAction _menuPauseAction;
    private InputAction _menuUnpauseAction;

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
        _menuPauseAction = _playerInput.actions["Pause"];
        _menuUnpauseAction = _playerInput.actions["Unpause"];
    }

    void UpdateInputs()
    {
        MoveInput = _moveAction.ReadValue<Vector2>();
        BoostInput = _boostAction.ReadValue<Vector2>();
        MenuPauseInput = _menuPauseAction.WasPressedThisFrame();
        MenuUnpauseInput = _menuUnpauseAction.WasPressedThisFrame();
    }
}
