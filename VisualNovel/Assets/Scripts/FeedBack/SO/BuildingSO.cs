using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Building", menuName = "Map/Building")]
public class BuildingSO : ScriptableObject
{
    [Tooltip("빌딩 아이디")]
    [SerializeField] private int id;

    [Tooltip("빌딩 이름")]
    [SerializeField] private string buildingName;

    [Tooltip("빌딩 한글 이름")]
    [SerializeField] private string buildingNameKr;

    [Tooltip("빌딩 잠금 여부")]
    [SerializeField] private bool isLocked;

    [Tooltip("자식(플레이스) id의 리스트")]
    [SerializeField] private List<int> childrenIdList;

    public int Id { get => id; }
    public string BuildingName { get => buildingName; }
    public string BuildingNameKr { get => buildingNameKr; }
    public bool IsLocked { get => isLocked; }
    public List<int> ChildrenIdList { get => childrenIdList; }
}
