using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSignsSeek : MonoBehaviour
{
    [SerializeField] private SearchDuplet _searchDuplet;
    [SerializeField] private RandomSpawner _randomSpawner;

    private void OnEnable()
    {
        SearchDuplet.onSeekSingsAdded += EndGameCheck;
    }

    private void OnDisable()
    {
        SearchDuplet.onSeekSingsAdded -= EndGameCheck;
    }

    private void EndGameCheck()
    {
        if (_searchDuplet.SeekSignCount == _randomSpawner.SignsCount)
        {
            Debug.Log("Game is End");
        }
    }
}
