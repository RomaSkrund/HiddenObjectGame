using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnPoison : MonoBehaviour
{
    [SerializeField] private GameObject _poisonPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private GameObject _bottleSprite;
    [SerializeField] private GameObject _thornsCollider;

    public static Action onPoisonGeted;

    private void OnMouseDown()
    {
        Instantiate(_poisonPrefab, _parentInventory);
        _bottleSprite.SetActive(false);
        gameObject.SetActive(false);
        onPoisonGeted?.Invoke();
        _thornsCollider.SetActive(true);
    }
}
