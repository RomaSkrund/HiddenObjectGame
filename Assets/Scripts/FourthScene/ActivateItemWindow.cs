using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateItemWindow : MonoBehaviour
{
    [SerializeField] private GameObject _itemWindow;

    private void OnEnable()
    {
        OpenItemInInventory.onItemOpened += ActivateWindow;
    }

    private void OnDisable()
    {
        OpenItemInInventory.onItemOpened -= ActivateWindow;
    }

    private void ActivateWindow()
    {
        _itemWindow.SetActive(true);
    }
}
