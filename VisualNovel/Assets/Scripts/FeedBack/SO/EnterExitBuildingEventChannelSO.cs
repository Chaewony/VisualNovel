using UnityEngine;
using UnityEngine.Events;

public enum BuildingTrigger
{
    enter, //빌딩 들어가기
    exit //빌딩 나가기
}

[CreateAssetMenu(menuName = "Events/EnterExit Event Channel")]
public class EnterExitBuildingEventChannelSO : ScriptableObject
{
    public event UnityAction <BuildingTrigger, int> OnEventRaised;
    [ContextMenu("마우스 클릭")]
    public void RaiseEvent(BuildingTrigger trigger, int id)
    {
        OnEventRaised?.Invoke(trigger, id);
    }
}
