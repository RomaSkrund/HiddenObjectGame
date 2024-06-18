using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishMiniGame : MonoBehaviour
{
    public static Action onThreeDoorMiniGameEnded;

    [SerializeField] private Image _bg;
    [SerializeField] private Sprite _emptyRoom;
    [SerializeField] private Sprite _threeDoors;
    [SerializeField] private GameObject _hiddenItemsGroup;
    [SerializeField] private GameObject _poisonBoxUI;
    [SerializeField] private GameObject _searchDupletUI;

    private int _countEndedMiniGame = 0;

    private void OnEnable()
    {
        onThreeDoorMiniGameEnded += MiniGameCountCheck;
    }

    private void OnDisable()
    {
        onThreeDoorMiniGameEnded -= MiniGameCountCheck;
    }

    private void MiniGameCountCheck()
    {
        _countEndedMiniGame++;
        if(_countEndedMiniGame != 3)
        {
            _bg.sprite = _emptyRoom;
            Invoke(nameof(ShowThreeDoors), 3f);
        }
        else if( _countEndedMiniGame == 3)
        {
            TasksAddAndRemove.onNewTaskRemoved?.Invoke("Открыть все двери");
            _hiddenItemsGroup.SetActive(true);
            _searchDupletUI.SetActive(true);
            _poisonBoxUI.SetActive(false);
        }
    }

    private void ShowThreeDoors()
    {
        _bg.sprite = _threeDoors;
    }
}
