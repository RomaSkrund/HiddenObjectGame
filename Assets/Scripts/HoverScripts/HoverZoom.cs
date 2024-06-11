using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverZoom : MonoBehaviour
{
    public static Action onZoomHovered;
    public static Action onZoomNotHovered;

    private void OnMouseEnter()
    {
        onZoomHovered?.Invoke();
    }

    private void OnMouseExit()
    {
        onZoomNotHovered?.Invoke();
    }

    private void OnDisable()
    {
        onZoomNotHovered?.Invoke();
    }
}
