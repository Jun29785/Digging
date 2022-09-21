using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidController : MonoBehaviour
{
    public static AndroidController Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Update()
    {
        Controll();
    }

    void Controll()
    {
        var gm = GameManager.Instance;
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (gm.OpenedTabs.Count > 0)
                {
                    gm.OpenedTabs[-1].GetComponent<Tab>().InActive.Invoke();
                    gm.OpenedTabs.RemoveAt(-1);
                }
            }
        }
    }
}
