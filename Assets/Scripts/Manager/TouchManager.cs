using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class TouchManager :MonoBehaviour
{
    private PlayerInput _playerInput;
    //public MainMenuTransition mainMenuTransition;
    public GameObject starterScene;


    private InputAction _touchPressAction;
    //private InputAction _touchPositionAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _touchPressAction = _playerInput.actions["TouchPress"];
        //_touchPositionAction = _playerInput.actions["TouchPosition"];
    }

    #region Events Function
    private void OnEnable()
    {
        _touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        _touchPressAction.performed -= TouchPressed;
    }
    #endregion

    private void TouchPressed(InputAction.CallbackContext ctx)
    {
        float value = ctx.ReadValue<float>();
        Debug.Log(value);
        starterScene.SetActive(true);
        //mainMenuTransition.OnStartMenuTouch();
    }
}
