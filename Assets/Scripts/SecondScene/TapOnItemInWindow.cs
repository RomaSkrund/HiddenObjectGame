using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnItemInWindow : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private Sprite _windowWithOtherItem;
    [SerializeField] private Sprite _windowWithoutOtherItem;
    [SerializeField] private Sprite _windowWithoutThisItem;
    [SerializeField] private Sprite _clearWindow;
    [SerializeField] private SpriteRenderer _windowSpriteRenderer;
    [SerializeField] private GameObject _windowOpenerCollider;

    private void OnMouseDown()
    {
        if(_windowSpriteRenderer.sprite == _windowWithOtherItem)
        {
            _windowSpriteRenderer.sprite = _windowWithoutThisItem;
        }
        else if (_windowSpriteRenderer.sprite == _windowWithoutOtherItem)
        {
            _windowSpriteRenderer.sprite = _clearWindow;
            _windowOpenerCollider.SetActive(false);
        }
        Instantiate(_itemPrefab, _parentInventory);
        gameObject.SetActive(false);
    }
}
