using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "new Place", menuName = "Map/Place")]
public class PlaceSO : ScriptableObject
{
    [Tooltip("�÷��̽� ���̵�")]
    [SerializeField] private int id;

    [Tooltip("�÷��̽� �̸�")]
    [SerializeField] private string placeName;

    [Tooltip("�÷��̽� �ѱ� �̸�")]
    [SerializeField] private string placeNameKr;

    [Tooltip("�÷��̽� ��� ����")]
    [SerializeField] private bool isLocked;

    [Tooltip("�θ�(����) id")]
    [SerializeField] private int parentId;

    public int Id { get => id; }
    public string PlaceName { get => placeName; }
    public string PlaceNameKr { get => placeNameKr; }
    public bool IsLocked { get => isLocked; }
    public int ParentId { get => parentId; }
}
