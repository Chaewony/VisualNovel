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

    private void Start() // awake�� �Ἥ on enable���� ���� �۵��ϰ� �Ǹ� �̺�Ʈ ������ ���� �� ������ ���۵Ǳ� ������ ���ϴ´�� �ȵ�
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

    /*private void detectEnter(int id) //�������� ������ �̵�
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

    private void detectMove(Trigger trigger)//�ʿ��� �� �� �̵�
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
