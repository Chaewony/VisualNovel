using UnityEngine;
using UnityEngine.Events;

public enum Trigger
{
    moveLeft,
    moveRight,
}

[CreateAssetMenu(menuName = "Events/Move Event Channel")]
public class MoveMapEventChannelSO : ScriptableObject
{
    public event UnityAction <Trigger>OnEventRaised;
    [ContextMenu("마우스 클릭")]
    public void RaiseEvent(Trigger trigger)
    {
        OnEventRaised?.Invoke(trigger);
    }
}
