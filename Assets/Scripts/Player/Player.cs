using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public LevelDatabase levelDB;

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

    private void UpdateLevel(int selectedOption)
    {
        LevelSelection levelSel = levelDB.GetLevelSelection(selectedOption);
        levelSprite.sprite = levelSel.levleSelectionSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
