using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnFullStump : MonoBehaviour
{
    [SerializeField] private GameObject _poisonCollider;

    private void OnMouseDown()
    {
        PoisonVideoPlayer.onVideoPlayed?.Invoke(7);
        gameObject.SetActive(false);
        _poisonCollider.SetActive(true);
    }
}
