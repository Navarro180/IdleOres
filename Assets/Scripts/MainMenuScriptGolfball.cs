using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScriptGolfball : MonoBehaviour
{
    // ^^^^^^ I can explain... :')
    // The latest merge refused to work without giving this script an esoteric name. I swear to f#%@ing god. 
    // ~-= "Coding is my passion" =-~   - Ethan ;)

    public GameObject startPanel;
    public GameObject optionPanel;

    //private InputManager inputManager;

    //private void Awake()
    //{
    //    inputManager = InputManager.Instance;
    //}

    //private void OnEnable()
    //{
    //    inputManager.OnStartTouch += OpenStartPanel;
    //}

    //private void OnDisable()
    //{
    //    inputManager.OnEndTouch -= OpenStartPanel;
    //}
    //public void OpenStartPanel(Vector2 sceenPos, float time)
    //{
    //    startPanel.SetActive(true);
    //}

    //public void CloseStartPanel()
    //{
    //    startPanel.SetActive(false);
    //}

    public void OpenOptionPanel()
    {
        optionPanel.SetActive(true);
    }

    public void CloseOptionPanel()
    {
        optionPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
