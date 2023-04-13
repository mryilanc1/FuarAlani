using System;
using UnityEngine;

public class CustomButton : MonoBehaviour
{
    [Serializable]
    public class RaycastEnterEvent : UnityEngine.Events.UnityEvent
    {
    }

    [Serializable]
    public class RaycastExitEvent : UnityEngine.Events.UnityEvent
    {
    }

    public RaycastEnterEvent raycastEnterEvent;
    public RaycastExitEvent raycastExitEvent;

    public bool isClicked = false;

    public void OnMouseDown()
    {
        isClicked = !isClicked;
        if (isClicked)
            raycastEnterEvent.Invoke();
        else
            raycastExitEvent?.Invoke();
    }
}