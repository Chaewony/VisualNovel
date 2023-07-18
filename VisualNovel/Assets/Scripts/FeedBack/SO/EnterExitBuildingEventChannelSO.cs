using UnityEngine;
using UnityEngine.Events;

public enum BuildingTrigger
{
    enter, //���� ����
    exit //���� ������
}

[CreateAssetMenu(menuName = "Events/EnterExit Event Channel")]
public class EnterExitBuildingEventChannelSO : ScriptableObject
{
    public event UnityAction <BuildingTrigger, int> OnEventRaised;
    [ContextMenu("���콺 Ŭ��")]
    public void RaiseEvent(BuildingTrigger trigger, int id)
    {
        OnEventRaised?.Invoke(trigger, id);
    }
}
