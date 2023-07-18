using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Map", menuName = "Map/Map")]
public class MapSO : ScriptableObject
{
    [Tooltip("¸Ê ¾ÆÀÌµð")] 
    [SerializeField] private int id;

    [Tooltip("¸Ê ÀÌ¸§")]
    [SerializeField] private string mapName;

    [Tooltip("¸Ê ÇÑ±Û ÀÌ¸§")]
    [SerializeField] private string mapNameKr;

    [Tooltip("¸Ê Àá±Ý ¿©ºÎ")]
    [SerializeField] private bool isLocked;

    [Tooltip("µðÆúÆ® ½ÃÀÛ ¸Ê")]
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
