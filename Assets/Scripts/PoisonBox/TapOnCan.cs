using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnCan : MonoBehaviour
{
    [SerializeField] private GameObject _allStumpCollider;

    private void OnMouseDown()
    {
        PoisonVideoPlayer.onVideoPlayed?.Invoke(6);
        gameObject.SetActive(false);
        _allStumpCollider.SetActive(true);
    }
}
