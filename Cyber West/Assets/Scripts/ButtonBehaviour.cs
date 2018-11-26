using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IPointerDownHandler, IPointerUpHandler
{
    public Text buttonText;
    Color32 magenta = new Color32(235, 35, 237, 255);
    Color32 lightblue = new Color32(11, 172, 232, 255);

    public void OnPointerEnter(PointerEventData eventData)
    {
        Color temp = buttonText.color;
        buttonText.color = Color.red;
    }

    public void OnSelect(BaseEventData eventData)
    {
        buttonText.color = Color.red;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        buttonText.color = lightblue;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonText.color = magenta;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnDeselect(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonText.color = Color.red;
    }
}