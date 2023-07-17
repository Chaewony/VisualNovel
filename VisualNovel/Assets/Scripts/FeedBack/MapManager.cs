using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] public MapOnOffEventChannelSO mapOnOffEvent;
    [SerializeField] public MoveEventChannelSO moveEvent;
    [SerializeField] public List<MapSO> mapSO;

    private int currentOnMapId;

    private void Start() // awake�� �Ἥ on enable���� ���� �۵��ϰ� �Ǹ� �̺�Ʈ ������ ���� �� ������ ���۵Ǳ� ������ ���ϴ´�� �ȵ�
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
