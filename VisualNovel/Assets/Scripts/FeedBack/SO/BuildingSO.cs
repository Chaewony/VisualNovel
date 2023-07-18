using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Building", menuName = "Map/Building")]
public class BuildingSO : ScriptableObject
{
    [Tooltip("ºôµù ¾ÆÀÌµğ")]
    [SerializeField] private int id;

    [Tooltip("ºôµù ÀÌ¸§")]
    [SerializeField] private string buildingName;

    [Tooltip("ºôµù ÇÑ±Û ÀÌ¸§")]
    [SerializeField] private string buildingNameKr;

    [Tooltip("ºôµù Àá±İ ¿©ºÎ")]
    [SerializeField] private bool isLocked;

    [Tooltip("ºÎ¸ğ(¸Ê) id")]
    [SerializeField] private int parentId;

    public int Id { get => id; }
    public string BuildingName { get => buildingName; }
    public string BuildingNameKr { get => buildingNameKr; }
    public bool IsLocked { get => isLocked; }
    public int ParentId { get => parentId; }
}
