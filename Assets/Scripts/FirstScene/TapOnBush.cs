using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBush : MonoBehaviour
{
    [SerializeField] private GameObject _searchItemsWindow;
    [SerializeField] private GameObject _searchDuplet;

    private void OnMouseDown()
    {
        _searchItemsWindow.SetActive(true);
        _searchDuplet.SetActive(true);
        gameObject.SetActive(false);
    }
}
