using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollider : MonoBehaviour
{
    [SerializeField] public MoveEventChannelSO moveEvent;
    [SerializeField] private bool isRight;
    [SerializeField] private bool isLeft;

    public void OnMouseDown()
    {
        Debug.Log("zz");
        if (isRight)
            moveEvent.RaiseEvent(Trigger.moveRight);
        else if (isLeft)
            moveEvent.RaiseEvent(Trigger.moveLeft);
    }
}
