using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using Define;

public class UserDataManager : Singleton<UserDataManager>
{
    public UserData userData;

    string path;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "UserData.json");
    }

    public void InitializeUserData()
    {
        userData.Coin = 0;
        userData.CoolerLevel = 0;
        userData.DrillLevel = 0;
        userData.EngineLevel = 0;
        userData.StorageLevel = 0;
        userData.Minerals = new SerializableDictionary<string, long>();
        userData.Depth = 0;
        userData.CurrentDepthProgress = 0;

        foreach(var mineral in Enum.GetValues(typeof(MineralType)))
            userData.Minerals.Add(mineral.ToString(),0);
    }

    public void LoadUserData()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = File.OpenRead(path);
            userData = (UserData)bf.Deserialize(stream);
            stream.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public void SaveUserData()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = File.Create(path);

            bf.Serialize(stream, userData);
            stream.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}
