using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnPaper : MonoBehaviour
{
    [SerializeField] private GameObject _chestGroup;
    [SerializeField] private GameObject _paper;
    [SerializeField] private GameObject _chestPrefab;

    private void OnMouseDown()
    {
        _chestGroup.SetActive(false);
        _paper.SetActive(true);
        Destroy(_chestPrefab);
        MapButtonActivated.onNextLocationActivated?.Invoke(2);
    }
}
