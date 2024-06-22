using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllSignsSeek : MonoBehaviour
{
    [SerializeField] private SearchDuplet _searchDuplet;
    [SerializeField] private RandomSpawner _randomSpawner;
    [SerializeField] private GameObject _magicDoorGroup;
    [SerializeField] private GameObject _magicDoorCollider;
    [SerializeField] private GameObject _miniGameUIGroup;
    [SerializeField] private GameObject _hintGroup;
    [SerializeField] private GameObject _poisonGroup;
    [SerializeField] private GameObject _inventory;
    [SerializeField] private Image _BG;
    [SerializeField] private Sprite _doorWithoutMagic;

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
        MapButtonActivated.onNextLocationActivated?.Invoke(4);
        TasksAddAndRemove.onNewTaskAdded?.Invoke("Войти в избу");
        _magicDoorGroup.SetActive(false);
        _magicDoorCollider.SetActive(true);
        Cursor.visible = true;
        _miniGameUIGroup.SetActive(false);
        _hintGroup.SetActive(true);
        _poisonGroup.SetActive(true);
        _inventory.SetActive(true);
        _BG.sprite = _doorWithoutMagic;
    }
}
