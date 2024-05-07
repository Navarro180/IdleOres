using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject tutorialPanel;

    #region ChangeScene
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    #endregion

    #region Canvas Activations/Deactivation
    public void OpenDialoguePanel()
    {
        dialoguePanel.SetActive(true);
        tutorialPanel.SetActive(false);
    }

    public void CloseDialoguePanel()
    {
        dialoguePanel.SetActive(false);
    }
    #endregion
}
