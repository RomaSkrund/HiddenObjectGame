using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLastItem : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private GameObject _itemGetGroup;

    private void OnMouseDown()
    {
        Instantiate(_itemPrefab, _parentInventory);
        _itemGetGroup.SetActive(false);
    }
}
