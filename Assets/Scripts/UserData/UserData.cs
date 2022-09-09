using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public BigInteger Coin;
    public SerializableDictionary<string, BigInteger> Minerals = new SerializableDictionary<string, BigInteger>();
    public int Depth; // ���� : km
    public BigInteger CurrentDepthProgress; // ���� ���൵ -> �ʿ��� ��ü ��ġ�� �ڵ带 ���� ���� ex) Depth * 10 || ���� ��� ��ġ��ŭ �����ߴ��� ��Ÿ���� ��ġ
    /* ���� �� �ý��� ���� */
    public int StorageLevel;    // â��
    public int CoolerLevel;     // ��
    public int EngineLevel;     // ����
    public int DrillLevel;      // �帱
}
