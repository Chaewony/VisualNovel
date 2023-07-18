using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Building", menuName = "Map/Building")]
public class BuildingSO : ScriptableObject
{
    [Tooltip("���� ���̵�")]
    [SerializeField] private int id;

    [Tooltip("���� �̸�")]
    [SerializeField] private string buildingName;

    [Tooltip("���� �ѱ� �̸�")]
    [SerializeField] private string buildingNameKr;

    [Tooltip("���� ��� ����")]
    [SerializeField] private bool isLocked;

    [Tooltip("�θ�(��) id")]
    [SerializeField] private int parentId;

    public int Id { get => id; }
    public string BuildingName { get => buildingName; }
    public string BuildingNameKr { get => buildingNameKr; }
    public bool IsLocked { get => isLocked; }
    public int ParentId { get => parentId; }
}
