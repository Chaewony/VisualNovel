using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Map On Off Event Channel")]
public class MapOnOffEventChannelSO : ScriptableObject
{
    public event UnityAction<int> OffEventRaised;
    public event UnityAction<int> OnEventRaised;
    [ContextMenu("¸Ê ÄÑ±â/²ô±â")]
    public void RaiseOffEvent(int id)
    {
        OffEventRaised?.Invoke(id);
    }

    public void RaiseOnEvent(int id)
    {
        OnEventRaised?.Invoke(id);
    }
}

