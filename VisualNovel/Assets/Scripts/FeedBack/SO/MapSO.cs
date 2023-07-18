using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Map", menuName = "Map/Map")]
public class MapSO : ScriptableObject
{
    [Tooltip("�� ���̵�")] 
    [SerializeField] private int id;

    [Tooltip("�� �̸�")]
    [SerializeField] private string mapName;

    [Tooltip("�� �ѱ� �̸�")]
    [SerializeField] private string mapNameKr;

    [Tooltip("�� ��� ����")]
    [SerializeField] private bool isLocked;

    [Tooltip("����Ʈ ���� ��")]
    [SerializeField] private bool isDefault;

    public int Id { get => id; }
    public string MapName { get => mapName; }
    public string MapNameKr { get => mapNameKr; }
    public bool IsLocked { get => isLocked; }
    public bool IsDefault { get => isDefault; }

    /*public MapSO(int id, string map, bool isLocked)
    {
        this.id = id;
        this.map = map;
        this.isLocked = isLocked;
    }*/
}
