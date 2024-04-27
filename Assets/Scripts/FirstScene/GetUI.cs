using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUI : MonoBehaviour
{
    [SerializeField] private GameObject _inventaryItem;
    [SerializeField] private GameObject _getItemWindow;

    private void OnMouseDown()
    {
        _inventaryItem.SetActive(true);
        _getItemWindow.SetActive(false);
    }
}
