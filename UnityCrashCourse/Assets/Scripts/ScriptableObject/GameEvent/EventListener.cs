using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[AddComponentMenu("Shadow/Game Event Listener")]
public class EventListener : MonoBehaviour
{
    [SerializeField] protected GameEvent Event;

    [SerializeField] UnityEvent Response;


    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(string eventName)
    {
        if(gameObject.activeInHierarchy)
        {
            Response.Invoke();
        }
    }
}