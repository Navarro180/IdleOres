using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this well tell unity to make it possible to create 
//this object through CreatAssetMenu
[CreateAssetMenu]
public class LevelDatabase : ScriptableObject
{
    public LevelSelection[] levels;

    public int LevelCount {  get { return levels.Length; } }

    public LevelSelection GetLevelSelection(int index)
    {
        return levels[index];
    }
}
