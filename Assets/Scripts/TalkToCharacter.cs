using System;
using UnityEngine;

public class TalkToCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _dialogGroup;

    public static Action onMouseOnCharMoved;
    public static Action onMouseOutCharMoved;

    private void OnMouseDown()
    {
        _dialogGroup.SetActive(true);
    }

    private void OnMouseEnter()
    {
        onMouseOnCharMoved?.Invoke();
    }

    private void OnMouseExit()
    {
        onMouseOutCharMoved?.Invoke();
    }
}
