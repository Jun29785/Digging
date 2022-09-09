using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

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
