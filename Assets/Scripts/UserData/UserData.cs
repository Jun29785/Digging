using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    [SerializeField]
    public string Coin;
    public SerializableDictionary<string, long> Minerals = new SerializableDictionary<string, long>();
    public int Depth; // 단위 : km
    public string CurrentDepthProgress; // 현재 진행도 -> 필요한 전체 수치는 코드를 통한 계산식 ex) Depth * 10 || 현재 어느 수치만큼 진행했는지 나타내는 수치
    /* 게임 내 시스템 레벨 */
    public int StorageLevel;    // 창고
    public int CoolerLevel;     // 쿨러
    public int EngineLevel;     // 엔진
    public int DrillLevel;      // 드릴

    
}
