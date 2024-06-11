using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSignsSeek : MonoBehaviour
{
    [SerializeField] private SearchDuplet _searchDuplet;
    [SerializeField] private RandomSpawner _randomSpawner;
    [SerializeField] private GameObject _magicDoorGroup;
    [SerializeField] private GameObject _magicDoorCollider;
    [SerializeField] private GameObject _miniGameUIGroup;
    [SerializeField] private GameObject _hintGroup;
    [SerializeField] private GameObject _poisonGroup;

    private void OnEnable()
    {
        SearchDuplet.onSeekSingsAdded += EndGameCheck;
        MiniGameSkip.onSkipButtonPushed += EndGame;
    }

    private void OnDisable()
    {
        SearchDuplet.onSeekSingsAdded -= EndGameCheck;
        MiniGameSkip.onSkipButtonPushed -= EndGame;
    }

    private void EndGameCheck()
    {
        if (_searchDuplet.SeekSignCount == _randomSpawner.SignsCount)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        _magicDoorGroup.SetActive(false);
        _magicDoorCollider.SetActive(true);
        Cursor.visible = true;
        _miniGameUIGroup.SetActive(false);
        _hintGroup.SetActive(true);
        _poisonGroup.SetActive(true);
    }
}
