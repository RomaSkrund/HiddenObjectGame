using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBoiler : MonoBehaviour
{
    public static Action onIngredientsAdded;

    [SerializeField] private CircleCollider2D _boilerCollider;
    [SerializeField] private GameObject _finalPoison;

    private void OnEnable()
    {
        onIngredientsAdded += ActivateBoilerCollider;
    }

    private void OnDisable()
    {
        onIngredientsAdded -= ActivateBoilerCollider;
    }

    private void ActivateBoilerCollider()
    {
        _boilerCollider.enabled = true;
    }

    private void OnMouseDown()
    {
        PlayVideoBoiler.onVideoPlayed?.Invoke(5);
        _finalPoison.SetActive(true);
        _boilerCollider.enabled = false;
    }
}
