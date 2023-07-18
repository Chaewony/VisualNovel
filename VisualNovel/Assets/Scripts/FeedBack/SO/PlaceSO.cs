using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Place", menuName = "Map/Place")]
public class PlaceSO : ScriptableObject
{
    [Tooltip("플레이스 아이디")]
    [SerializeField] private int id;

    [Tooltip("플레이스 이름")]
    [SerializeField] private string placeName;

    [Tooltip("플레이스 한글 이름")]
    [SerializeField] private string placeNameKr;

    [Tooltip("플레이스 잠금 여부")]
    [SerializeField] private bool isLocked;

    [Tooltip("부모(빌딩) id")]
    [SerializeField] private int parentId;

    public int Id { get => id; }
    public string PlaceName { get => placeName; }
    public string PlaceNameKr { get => placeNameKr; }
    public bool IsLocked { get => isLocked; }
    public int ParentId { get => parentId; }
}
