using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverCharacter : MonoBehaviour
{
    public static Action onCharacterHovered;
    public static Action onCharacterNotHovered;

    private void OnMouseEnter()
    {
        onCharacterHovered?.Invoke();
    }

    private void OnMouseExit()
    {
        onCharacterNotHovered?.Invoke();
    }

    private void OnDisable()
    {
        onCharacterNotHovered?.Invoke();
    }
}
