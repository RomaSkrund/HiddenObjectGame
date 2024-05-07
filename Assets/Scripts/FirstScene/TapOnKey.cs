using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnKey : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _woodSpriteRenderer;
    [SerializeField] private Sprite _hollowWithoutKey;
    [SerializeField] private GameObject _keyPrefab;
    [SerializeField] private Transform _parentInventory;

    private void OnMouseDown()
    {
        _woodSpriteRenderer.sprite = _hollowWithoutKey;
        Instantiate(_keyPrefab, _parentInventory);
        gameObject.SetActive(false);
    }
}
