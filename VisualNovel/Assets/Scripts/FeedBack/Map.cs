using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] private int mapId;
    [SerializeField] public MapOnOffEventChannelSO mapOnOffEvent;

    private void OnEnable()
    {
        mapOnOffEvent.OffEventRaised += OffMap;
        mapOnOffEvent.OnEventRaised += OnMap;
    }

    private void OnDisable()
    {
        //mapOnOffEvent.OffEventRaised -= OffMap;
        //mapOnOffEvent.OnEventRaised -= OnMap;
    }

    public void OffMap(int id)
    {
        if (id == mapId)
            this.gameObject.SetActive(false);
    }

    public void OnMap(int id)
    {
        if (id == mapId)
            this.gameObject.SetActive(true);
    }
}
