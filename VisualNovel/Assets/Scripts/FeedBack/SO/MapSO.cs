using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Map", menuName = "Map/Map")]
public class MapSO : ScriptableObject
{
    [Tooltip("맵 아이디")] 
    [SerializeField] private int id;

    [Tooltip("맵 이름")]
    [SerializeField] private string mapName;

    [Tooltip("맵 한글 이름")]
    [SerializeField] private string mapNameKr;

    [Tooltip("맵 잠금 여부")]
    [SerializeField] private bool isLocked;

    [Tooltip("맵 오브젝트 현재 활성화 여부")]
    [SerializeField] private bool isOn;

    [Tooltip("자식(빌딩) id의 리스트")]
    [SerializeField] private List<int> childrenIdList;

    public int Id { get => id; }
    public string MapName { get => mapName; }
    public string MapNameKr { get => mapNameKr; }
    public bool IsLocked { get => isLocked; }
    public bool IsOn { get => isOn; }
    public List<int> ChildrenIdList { get => childrenIdList; }

    /*public MapSO(int id, string map, bool isLocked)
    {
        this.id = id;
        this.map = map;
        this.isLocked = isLocked;
    }*/
}
