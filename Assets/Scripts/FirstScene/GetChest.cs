using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChest : MonoBehaviour
{
    [SerializeField] private GameObject _chestInInventory;
    [SerializeField] private GameObject _getChestGroup;
    [SerializeField] private GameObject _woodCollider;

    private void OnMouseDown()
    {
        _chestInInventory.SetActive(true);
        _getChestGroup.SetActive(false);
        TasksAddAndRemove.onNewTaskAdded?.Invoke("Открыть шкатулку");
        _woodCollider.SetActive(true);
    }
}
