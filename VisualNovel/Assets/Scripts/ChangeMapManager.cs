using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMapManager : MonoBehaviour
{
    [SerializeField] private List<ChangeMapHandler> triggerList;

    private void OnEnable()
    {
        foreach (var trigger in triggerList)
        {
            trigger.OnColliderClicked += UpdateDisplay;
        }
    }

    private void OnDisable()
    {
        foreach (var trigger in triggerList)
        {
            trigger.OnColliderClicked -= UpdateDisplay;
        }
    }

    private void UpdateDisplay(GameObject currentMap, GameObject nextMap)
    {
        currentMap.gameObject.SetActive(false);
        nextMap.gameObject.SetActiveRecursively(true);
    }
}
