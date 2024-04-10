using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LevelManager : MonoBehaviour
{
    public LevelDatabase levelDB;

    public TextMeshProUGUI nameText;
    public UnityEngine.UI.Image levelSprite;

    private int selectedOption = 0;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateLevel(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= levelDB.LevelCount)
        {
            selectedOption = 0;
        }

        UpdateLevel(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = levelDB.LevelCount - 1;
        }

        UpdateLevel(selectedOption);
        Save();
    }

    private void UpdateLevel(int selectedOption)
    {
        LevelSelection levelSel = levelDB.GetLevelSelection(selectedOption);
        levelSprite.sprite = levelSel.levleSelectionSprite;
        nameText.text = levelSel.levelSelection;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
