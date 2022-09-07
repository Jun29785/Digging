using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public BigInteger Coin;
    public Dictionary<string, BigInteger> Mineral = new Dictionary<string, BigInteger>();
    
}
