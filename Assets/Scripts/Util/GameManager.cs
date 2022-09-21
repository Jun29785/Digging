using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public List<GameObject> OpenedTabs;

    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ExitGame()
    {
        UserDataManager.Instance.SaveUserData();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  
#else
        Application.Quit();
#endif
    }
}
