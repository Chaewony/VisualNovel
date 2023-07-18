using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    [SerializeField] public MapOnOffEventChannelSO mapOnOffEvent;
    [SerializeField] private MoveMapEventChannelSO moveMapEvent;
    [SerializeField] private List<MapSO> mapSO;
    [SerializeField] public EnterExitBuildingEventChannelSO enterExitEvent;

    private int currentMapId;
    public int CurrentMapId { get => currentMapId; }

    private void Start() // awake를 써서 on enable보다 먼저 작동하게 되면 이벤트 통지가 나간 후 구독이 시작되기 때문에 원하는대로 안됨
    {
        foreach (MapSO map in mapSO)
        {
            if(map.IsDefault==false)
            {
                mapOnOffEvent.RaiseOffEvent(map.Id);
            }
            else
            {
                currentMapId = map.Id;
                mapOnOffEvent.RaiseOnEvent(map.Id);
            }
        }
    }

    private void OnEnable()
    {
        moveMapEvent.OnEventRaised += detectMove;
        enterExitEvent.OnEventRaised += detectEnterExit;
    }

    /*private void detectEnter(int id) //빌딩에서 맵으로 이동
    {
        mapOnOffEvent.RaiseOnEvent(id);

        currentMapId = id;
    }*/

    private void detectEnterExit(BuildingTrigger trigger, int id)
    {
        if (trigger == BuildingTrigger.enter)
        {
            mapOnOffEvent.RaiseOffEvent(currentMapId);
            moveMapEvent.OnEventRaised -= detectMove;
        }

        else if (trigger == BuildingTrigger.exit)
        {
            mapOnOffEvent.RaiseOnEvent(currentMapId);
            moveMapEvent.OnEventRaised += detectMove;
        }
    }

    private void detectMove(Trigger trigger)//맵에서 맵 간 이동
    {
        if (currentMapId == mapSO.Count - 1 && trigger == Trigger.moveLeft)
            return;

        if (currentMapId == 0 && trigger == Trigger.moveRight)
            return;

        int offMapId = currentMapId;
        int onMapId = 0;

        if (trigger == Trigger.moveLeft)
            onMapId = currentMapId + 1;

        else if (trigger == Trigger.moveRight)
            onMapId = currentMapId - 1;

        currentMapId = onMapId;
        mapOnOffEvent.RaiseOnEvent(onMapId);
        mapOnOffEvent.RaiseOffEvent(offMapId);
    }
}
