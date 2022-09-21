using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    [SerializeField]
    public string Coin;
    public SerializableDictionary<string, long> Minerals = new SerializableDictionary<string, long>();
    public int Depth; // ���� : km
    public string CurrentDepthProgress; // ���� ���൵ -> �ʿ��� ��ü ��ġ�� �ڵ带 ���� ���� ex) Depth * 10 || ���� ��� ��ġ��ŭ �����ߴ��� ��Ÿ���� ��ġ
    /* ���� �� �ý��� ���� */
    public int StorageLevel;    // â��
    public int CoolerLevel;     // ��
    public int EngineLevel;     // ����
    public int DrillLevel;      // �帱

    
}
