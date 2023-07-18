using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitCollider : MonoBehaviour
{
    [SerializeField] public EnterExitBuildingEventChannelSO enterExitEvent;
    [SerializeField] private bool isEnter;
    [SerializeField] private bool isExit;

    public void OnMouseDown()
    {
        if (isEnter)
            enterExitEvent.RaiseEvent(BuildingTrigger.enter, GetComponentInParent<Building>().BuildingId);
        else if (isExit)
            enterExitEvent.RaiseEvent(BuildingTrigger.exit, GetComponentInParent<Place>().PlaceId);
    }
}
