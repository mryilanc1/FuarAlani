using System;
using UnityEngine;

namespace StarterAssets
{
    public class CustomButton : MonoBehaviour
    {
        [Serializable]
        public class RaycastEnterEvent : UnityEngine.Events.UnityEvent { }
        [Serializable]
        public class RaycastExitEvent : UnityEngine.Events.UnityEvent { }
        
        public RaycastEnterEvent raycastEnterEvent;
        public RaycastExitEvent raycastExitEvent;

        public void OnMouseDown ()
        {
            Debug.Log("OnMouseDown");
            raycastEnterEvent.Invoke();
        }
    }
}