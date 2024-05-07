using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverHand : MonoBehaviour
{
    public static Action onHandHovered;
    public static Action onHandNotHovered;

    private void OnMouseOver()
    {
        onHandHovered?.Invoke();
    }

    private void OnMouseExit()
    {
        onHandNotHovered?.Invoke();
    }
}
