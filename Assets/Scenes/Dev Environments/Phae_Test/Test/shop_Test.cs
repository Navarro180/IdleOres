using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class shop_Test : MonoBehaviour
{
    public static shop_Test instance { get; private set; }


    public int currentOres;

    public int money;
    public bool[] upgradesUnlocked = new bool[6] {true, false, false, false, false, false};


    public void Awake()
    {
        if (instance != null & instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
        Load();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfor.data"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfor.data", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            data.currentOres = data.currentOres;
            data.money = data.money;
            data.upgradesUnlocked = data.upgradesUnlocked;

            if (data.upgradesUnlocked == null)
            {
                upgradesUnlocked = new bool[6] { true, false, false, false, false, false };
            }

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfor.data");
        PlayerData_Storage data = new PlayerData_Storage();

        data.currentOres = currentOres;
        data. money = data.money;
        data. upgradesUnlocked = data.upgradesUnlocked;

        bf.Serialize(file, data);
        file.Close();
    }

}

    [Serializable]
class PlayerData_Storage
{
    public int currentOres;
    public int money;
    public bool[] upgradesUnlocked;
}