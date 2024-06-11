using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemInInventory : MonoBehaviour
{
    public static Action onItemOpened;

    private void OnMouseDown()
    {
        onItemOpened?.Invoke();
        Destroy(gameObject);
    }
}
