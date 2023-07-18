using UnityEngine;

public class MoveCollider : MonoBehaviour
{
    [SerializeField] public MoveMapEventChannelSO moveMapEvent;
    [SerializeField] private bool isRight;
    [SerializeField] private bool isLeft;

    public void OnMouseDown()
    {
        if (isRight)
        {
            moveMapEvent.RaiseEvent(Trigger.moveRight);
        }
        else if (isLeft)
        {
            moveMapEvent.RaiseEvent(Trigger.moveLeft);
        }
    }
}
