using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(menuName ="ScriptableObjects/Game Event")]
public class GameEvent : ScriptableObject
{

    readonly List<EventListener> eventListeners = 
        new List<EventListener>();

    public void Raise()
    {


        for(int i = eventListeners.Count -1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(this.name);
        }
    }

  
    public void RegisterListener(EventListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }


    public void UnregisterListener(EventListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }

}