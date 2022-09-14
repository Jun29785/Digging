using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using System.Text;

public class NumberSystem : MonoBehaviour
{
    public static NumberSystem Instance;

    static string[] Unit = new string[] { "", "만", "억", "조", "경", "해", "자","양"};

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public string ToString(BigInteger coin)
    {
        if (coin == 0) { return "0"; }

        int unitID = 0;

        string number = string.Format("{0:# #### #### #### #### #### #### ####}", coin).TrimStart();
        string[] splits = number.Split(' ');

        StringBuilder sb = new StringBuilder();

        for (int i = splits.Length; i > 0; i--)
        {
            int digits = 0;
            if (int.TryParse(splits[i - 1], out digits))
            {
                if (digits != 0)
                {
                    sb.Insert(0, $"{ digits}{ Unit[unitID] }");
                }
            }
            else
            {
                sb.Insert(0, $"{ splits[i - 1] }");
            }
            unitID++;
        }
        return sb.ToString();
    }
}
