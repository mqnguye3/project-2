using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContainerDrag : MonoBehaviour, IDragHandler
{
    RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = transform.parent.GetComponent<RectTransform>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }
}
