using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverGears : MonoBehaviour
{
    public static Action onGearsHovered;
    public static Action onGearsNotHovered;

    private void OnMouseEnter()
    {
        onGearsHovered?.Invoke();
    }

    private void OnMouseExit()
    {
        onGearsNotHovered?.Invoke();
    }

    private void OnDisable()
    {
        onGearsNotHovered?.Invoke();
    }
}
