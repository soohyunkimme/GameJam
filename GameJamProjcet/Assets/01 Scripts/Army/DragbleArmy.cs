using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragbleArmy : EventTrigger
{
    public bool isDragging { get; set; }

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
}