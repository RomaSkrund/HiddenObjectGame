using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnClosedChest : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _chestSR;
    [SerializeField] private Sprite _openedChest;
    [SerializeField] private GameObject _medallionCollider;

    private void OnMouseDown()
    {
        _chestSR.sprite = _openedChest;
        _medallionCollider.SetActive(true);
        gameObject.SetActive(false);
    }
}
