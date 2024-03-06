using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{
    public delegate void StartTouchEvent(UnityEngine.Vector2 pos, float time);
    public event StartTouchEvent OnStartTouch; 
    public delegate void EndTouchEvent(UnityEngine.Vector2 pos, float time);
    public event StartTouchEvent OnEndTouch;

    private TouchControls touchControls;

    

    private void Awake()
    {
        touchControls = new TouchControls();
    }

    private void OnEnable()
    {
        touchControls.Enable();
    }

    private void OnDisable()
    {
       touchControls.Disable();
    }

    private void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }

    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Started" + touchControls.Touch.TouchPosition.ReadValue<UnityEngine.Vector2>());
        if (OnStartTouch != null)
        {
            OnStartTouch(touchControls.Touch.TouchPosition.ReadValue<UnityEngine.Vector2>(), (float)context.startTime);
        }
    } 
    private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch ended" + touchControls.Touch.TouchPosition.ReadValue<UnityEngine.Vector2>());
        if (OnEndTouch != null)
        {
            OnEndTouch(touchControls.Touch.TouchPosition.ReadValue<UnityEngine.Vector2>(), (float)context.time);
        }
    }
}