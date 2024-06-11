using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnMatches : MonoBehaviour
{
    [SerializeField] private GameObject _matchesSprite;
    [SerializeField] private GameObject _stampCollider;

    public static Action onMatchesTapped;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        PoisonVideoPlayer.onVideoPlayed?.Invoke(1);
        onMatchesTapped?.Invoke();
        _matchesSprite.SetActive(false);
        _stampCollider.SetActive(true);
    }
}
