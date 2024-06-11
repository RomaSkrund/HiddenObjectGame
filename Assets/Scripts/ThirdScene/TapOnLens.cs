using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnLens : MonoBehaviour
{
    [SerializeField] private GameObject _lensPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private SpriteRenderer _stoneGroupSR;
    [SerializeField] private Sprite _stonesWithoutLens;
    [SerializeField] private GameObject _stonesCollider;
    

    private void OnMouseDown()
    {
        Instantiate(_lensPrefab, _parentInventory);
        _stoneGroupSR.sprite = _stonesWithoutLens;
        gameObject.SetActive(false);
        _stonesCollider.SetActive(false);
    }
}
