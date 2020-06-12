using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
using UnityEngine.EventSystems;
public class MenuPpalPuntuaciones : MonoBehaviour, ISelectHandler, IPointerEnterHandler
{
    // When highlighted with mouse.
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed mouse highlight.");
    }
    // When selected.
    public void OnSelect(BaseEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed selection.");
    }
}