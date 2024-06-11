using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnWorm : MonoBehaviour
{
    [SerializeField] private GameObject _wormPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private GameObject _rightBushGroup;
    private void OnMouseDown()
    {
        Instantiate(_wormPrefab, _parentInventory);
        gameObject.SetActive(false);
        _rightBushGroup.SetActive(false);
    }
}
