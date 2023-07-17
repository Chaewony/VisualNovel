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

    [Tooltip("�� ������Ʈ ���� Ȱ��ȭ ����")]
    [SerializeField] private bool isOn;

    [Tooltip("�ڽ�(����) id�� ����Ʈ")]
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
