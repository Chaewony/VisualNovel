using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Map", menuName = "Map")]
public class MapSO : ScriptableObject
{
    [Tooltip("¸Ê ¾ÆÀÌµð")]
    [SerializeField] private int id;

    [Tooltip("¸Ê ÀÌ¸§")]
    [SerializeField] private string map;

    [Tooltip("¸Ê Àá±Ý ¿©ºÎ")]
    [SerializeField] private bool isLocked;

    public int Id { get => id; }
    public string Map { get => map; }
    public bool IsLocked { get => isLocked; }

    /*public MapSO(int id, string map, bool isLocked)
    {
        this.id = id;
        this.map = map;
        this.isLocked = isLocked;
    }*/
}
