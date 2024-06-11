using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnItemsInBundle : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _parentInventory;

    private void OnMouseDown()
    {
        Instantiate(_itemPrefab, _parentInventory);
        gameObject.SetActive(false);
    }
}
