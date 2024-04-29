using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SignSpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite _defaultSign;
    [SerializeField] private Sprite _activeSign;
    [SerializeField] private Sprite _nonActiveSign;

    public static Action<string, Vector3> onSignPushed;

    private SpriteRenderer signSR;

    private bool _isSignDuplet = false;

    private void OnEnable()
    {
        SearchDuplet.onDupletSearched += Duplet;
        SearchDuplet.onNonDupletSearched += NonDuplet;
    }

    private void OnDisable()
    {
        SearchDuplet.onDupletSearched -= Duplet;
        SearchDuplet.onNonDupletSearched -= NonDuplet;
    }

    private void Start()
    {
        signSR = gameObject.GetComponent<SpriteRenderer>();
        signSR.sprite = _defaultSign;
    }

    private void OnMouseDown()
    {
        if (!_isSignDuplet)
        {
            signSR.sprite = _activeSign;

            onSignPushed?.Invoke(gameObject.name, gameObject.transform.position);
        }
    }

    private void NonDuplet(string firstName, string secondName)
    {
        if (gameObject.name ==  firstName || gameObject.name == secondName) 
        {
            signSR.sprite = _defaultSign;
        }
    }

    private void Duplet(string dupletName)
    {
        if (gameObject.name == dupletName)
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            signSR.enabled = true;
            signSR.sprite = _nonActiveSign;
            _isSignDuplet = true;
        }
    }
}
