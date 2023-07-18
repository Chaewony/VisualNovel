using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    [SerializeField] private int placeId;
    public int PlaceId { get => placeId; }
    [SerializeField] public MapOnOffEventChannelSO placeOnOffEvent;

    private void OnEnable()
    {
        placeOnOffEvent.OffEventRaised += OffPlace;
        placeOnOffEvent.OnEventRaised += OnPlace;
    }

    public void OffPlace(int id)
    {
        if (id == placeId)
            this.gameObject.SetActive(false);
    }
    public void OnPlace(int id)
    {
        if (id == placeId)
            this.gameObject.SetActive(true);
    }
}
