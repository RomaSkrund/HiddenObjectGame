using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChest : MonoBehaviour
{
    [SerializeField] private GameObject _chestInInventory;
    [SerializeField] private GameObject _getChestGroup;

    public static Action<string> onChestGeted;

    private void OnMouseDown()
    {
        _chestInInventory.SetActive(true);
        _getChestGroup.SetActive(false);
        onChestGeted?.Invoke("Открыть шкатулку");
    }
}
