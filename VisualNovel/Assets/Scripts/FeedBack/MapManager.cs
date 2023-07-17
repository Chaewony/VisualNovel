using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] public MapOnOffEventChannelSO mapOnOffEvent;
    [SerializeField] public MoveEventChannelSO moveEvent;
    [SerializeField] public List<MapSO> mapSO;

    private int currentOnMapId;

    private void Start() // awake를 써서 on enable보다 먼저 작동하게 되면 이벤트 통지가 나간 후 구독이 시작되기 때문에 원하는대로 안됨
    {
        moveEvent.OnEventRaised += detectMove;

        foreach (MapSO map in mapSO)
        {
            if(map.IsOn==false)
            {
                mapOnOffEvent.RaiseOffEvent(map.Id);
            }
            else
                currentOnMapId = map.Id;
        }
    }

    private void detectMove(Trigger trigger)
    {
        if (currentOnMapId == mapSO.Count - 1 && trigger == Trigger.moveLeft)
            return;

        if (currentOnMapId == 0 && trigger == Trigger.moveRight)
            return;

        int offMapId = currentOnMapId;
        int onMapId = 0;

        if (trigger == Trigger.moveLeft)
            onMapId = currentOnMapId + 1;

        else if (trigger == Trigger.moveRight)
            onMapId = currentOnMapId - 1;

        mapOnOffEvent.RaiseOnEvent(onMapId);
        mapOnOffEvent.RaiseOffEvent(offMapId);

        currentOnMapId = onMapId;
    }
}
