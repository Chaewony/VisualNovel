using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : Singleton<PlaceManager>
{
    [SerializeField] public EnterExitBuildingEventChannelSO enterExitEvent;
    [SerializeField] public MapOnOffEventChannelSO placeOnOffEvent;
    [SerializeField] public MapOnOffEventChannelSO mapOnOffEvent;
    [SerializeField] private List<PlaceSO> placeSO;
    [SerializeField] private MoveMapEventChannelSO moveEvent;

    private int currentId;

    private void OnEnable()
    {
        enterExitEvent.OnEventRaised += SetPlace;
    }

    private void Start()
    {
        foreach (PlaceSO place in placeSO)
        {
            placeOnOffEvent.RaiseOffEvent(place.Id);
        }
    }
    private void SetPlace(BuildingTrigger trigger, int id)
    {
        if(trigger == BuildingTrigger.enter)
        {
            moveEvent.OnEventRaised += MovePlace;
            foreach (PlaceSO place in placeSO)
            {
                if (place.ParentId == id)
                {
                    placeOnOffEvent.RaiseOnEvent(place.Id);
                    currentId = place.Id;
                    return;
                }
                else
                {
                    placeOnOffEvent.RaiseOffEvent(place.Id);
                }
            }
        }

        else if (trigger == BuildingTrigger.exit)
        {
            placeOnOffEvent.RaiseOffEvent(currentId);
            mapOnOffEvent.RaiseOnEvent(MapManager.Instance.CurrentMapId);
            moveEvent.OnEventRaised -= MovePlace;
        }

    }

    private void MovePlace(Trigger trigger)
    {
        List<int> siblingId = new List<int>();

        foreach (PlaceSO place in placeSO)
        {
            if (place.ParentId == placeSO[currentId].ParentId)
            {
                siblingId.Add(place.Id);
            }
        }

        if (trigger == Trigger.moveLeft)
        {
            if (currentId - 1 < siblingId[0])
                return;

            placeOnOffEvent.RaiseOffEvent(currentId);
            currentId = currentId - 1;
            placeOnOffEvent.RaiseOnEvent(currentId);
        }

        else if (trigger == Trigger.moveRight)
        {
            if (currentId + 1 > siblingId[siblingId.Count - 1])
                return;

            placeOnOffEvent.RaiseOffEvent(currentId);
            currentId = currentId + 1;
            placeOnOffEvent.RaiseOnEvent(currentId);
        }

    }
}
