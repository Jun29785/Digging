using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Define;

public class SceneController : Singleton<SceneController>
{
    public SceneType CurrentScene;

    protected override void Awake()
    {
        base.Awake();
    }

    public void LoadScene(SceneType scene)
    {
        SceneManager.LoadScene((int)scene);
    }
}
