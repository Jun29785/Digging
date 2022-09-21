using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Define;

public class UserDataManager : Singleton<UserDataManager>
{
    public UserData userData;

    string directory = "/SaveData/";
    string filename = "UserData.json";
    string path;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        path = Application.persistentDataPath + directory;
        Debug.Log($":: UserDataPath -> {path}");
        InitializeUserData();
        LoadUserData();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            LoadUserData();
    }

    public void InitializeUserData()
    {
        userData.Coin = "0";
        userData.CoolerLevel = 0;
        userData.DrillLevel = 0;
        userData.EngineLevel = 0;
        userData.StorageLevel = 0;
        userData.Minerals = new SerializableDictionary<string, long>();
        userData.Depth = 0;
        userData.CurrentDepthProgress = "0";

        foreach(var mineral in Enum.GetValues(typeof(MineralType)))
            userData.Minerals.Add(mineral.ToString(),0);
    }

    public void LoadUserData()
    {
        Debug.LogWarning($":: Start LoadUserData {DateTime.Now}");
        try
        {
            if (File.Exists(path + filename))
            {
                string json = File.ReadAllText(path + filename);
                Debug.Log($":: Json Data -> {json}");
                userData = JsonUtility.FromJson<UserData>(json);
            }
            else
            {
                Debug.LogWarning($":: SaveFile does not exit");
            }

            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream stream = File.OpenRead(path);
            //userData = (UserData)bf.Deserialize(stream);
            //stream.Close();
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
        Debug.LogWarning($":: End LoadUserData {DateTime.Now}");
    }

    public void SaveUserData()
    {
        Debug.LogWarning($":: Start SaveUserData {DateTime.Now}");
        try
        {
            
            if (!Directory.Exists(path))
            {
                // 존재하지 않다면
                Directory.CreateDirectory(path);
            }

            string json = JsonUtility.ToJson(userData);
            Debug.Log($":: Json Data -> {json}");

            File.WriteAllText(path + filename, json);

            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream stream = File.Create(path);

            //bf.Serialize(stream, userData);
            //stream.Close();
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
        Debug.LogWarning($":: End SaveUserData {DateTime.Now}");
    }
}
