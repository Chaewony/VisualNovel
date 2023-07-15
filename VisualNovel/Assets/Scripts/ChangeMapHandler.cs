using UnityEngine;
using System;

public class ChangeMapHandler : MonoBehaviour
{
    public event Action<GameObject, GameObject> OnColliderClicked = null;
    [SerializeField] private GameObject enterTarget = null;
    [SerializeField] private GameObject offTarget = null;

    [ContextMenu("마우스 클릭")]
    private void OnMouseDown()
    {
        OnColliderClicked?.Invoke(offTarget, enterTarget);
    }
}
