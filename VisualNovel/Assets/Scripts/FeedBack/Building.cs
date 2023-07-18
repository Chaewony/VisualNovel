using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private int buildingId;
    public int BuildingId { get => buildingId; }
    [SerializeField] public MapOnOffEventChannelSO buildingOnOffEvent;

    // Start is called before the first frame update
    private void OnEnable()
    {
        buildingOnOffEvent.OffEventRaised += OffBuilding;
        buildingOnOffEvent.OnEventRaised += OnBuilding;
    }

    public void OffBuilding(int id)
    {
        if (id == buildingId)
            this.gameObject.SetActive(false);
    }

    public void OnBuilding(int id)
    {
        if (id == buildingId)
            this.gameObject.SetActive(true);
    }
}
