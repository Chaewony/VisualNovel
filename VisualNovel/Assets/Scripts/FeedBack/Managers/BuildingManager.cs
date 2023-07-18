using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : Singleton<BuildingManager>
{
    [SerializeField] public MapOnOffEventChannelSO buildingOnOffEvent;
    [SerializeField] private List<BuildingSO> buildingSO;
    [SerializeField] public MapOnOffEventChannelSO MapOnOffEvent;

    private int currentBuildingId;
    public int CurrentBuildingId { get => currentBuildingId; set => currentBuildingId = value; }

    private void OnEnable()
    {
        MapOnOffEvent.OnEventRaised += ShowBuilding;
    }

    private void ShowBuilding(int id)
    {
        foreach (BuildingSO building in buildingSO)
        {
            if (MapManager.Instance.CurrentMapId == building.ParentId && !building.IsLocked) 
            {
                buildingOnOffEvent.RaiseOnEvent(building.Id);
            }
            else
            {
                buildingOnOffEvent.RaiseOffEvent(building.Id);
            }
        }
    }
}
