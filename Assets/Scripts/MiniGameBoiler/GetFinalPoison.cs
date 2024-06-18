using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalPoison : MonoBehaviour
{
    [SerializeField] private GameObject _miniGameBoilerGroup;
    [SerializeField] private GameObject _yagaSprite;
    [SerializeField] private GameObject _dialogWindow;
    [SerializeField] private GameObject _UI;
    [SerializeField] private GameObject _miniGameUI;

    private void OnEnable()
    {
        MiniGameSkip.onSkipButtonPushed += EndMiniGame;
    }

    private void OnDisable()
    {
        MiniGameSkip.onSkipButtonPushed -= EndMiniGame;
    }

    private void OnMouseDown()
    {
        EndMiniGame();
    }

    private void EndMiniGame()
    {
        _miniGameBoilerGroup.SetActive(false);
        _yagaSprite.SetActive(true);
        _dialogWindow.SetActive(true);
        _UI.SetActive(false);
        _miniGameUI.SetActive(false);
    }
}
