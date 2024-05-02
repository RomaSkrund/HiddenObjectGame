using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallSpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private Sprite _ballSprite;

    public static Action<string, Vector3> onBallPushed;

    public static Action onBallDistroyed;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _defaultSprite;
    }

    private void OnEnable()
    {
        DupletBalls.onDupletBallsSearched += Duplet;
        DupletBalls.onNonDupletBallsSearched += NonDuplet;
    }

    private void OnDisable()
    {
        DupletBalls.onDupletBallsSearched -= Duplet;
        DupletBalls.onNonDupletBallsSearched -= NonDuplet;
    }

    private void OnMouseDown()
    {
        _spriteRenderer.sprite = _ballSprite;
        onBallPushed?.Invoke(gameObject.name, gameObject.transform.position);
    }

    private void NonDuplet(string firstName, string secondName)
    {
        if (gameObject.name == firstName || gameObject.name == secondName)
        {
            Invoke(nameof(ChangeBallSprite), 0.5f);
        }
    }

    private void Duplet(string dupletName)
    {
        if (gameObject.name == dupletName)
        {
            Invoke(nameof(DestroyBall), 0.2f);
        }
    }

    private void ChangeBallSprite()
    {
        _spriteRenderer.sprite = _defaultSprite;
    }

    private void DestroyBall()
    {
        onBallDistroyed?.Invoke();
        Destroy(gameObject);
    }

}
