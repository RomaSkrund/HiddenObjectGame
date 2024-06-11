using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButtonActivated : MonoBehaviour
{
    [SerializeField] private Image _firstButton;
    [SerializeField] private Image _secondButton;
    [SerializeField] private Image _thirdButton;
    [SerializeField] private Image _fourthButton;

    [SerializeField] private Sprite _activeButton;
    [SerializeField] private Sprite _nonActiveButton;

    public static Action<int> onNextLocationActivated;

    private void OnEnable()
    {
        onNextLocationActivated += LocationChanged;
    }

    private void OnDisable()
    {
        onNextLocationActivated -= LocationChanged;
    }

    private void LocationChanged(int numberOfButton)
    {
        switch (numberOfButton)
        {
            case 2:
                _firstButton.sprite = _nonActiveButton;
                _secondButton.sprite = _activeButton;
                break;
            case 3:
                _secondButton.sprite = _nonActiveButton;
                _thirdButton.sprite = _activeButton;
                break;
            case 4:
                _thirdButton.sprite = _nonActiveButton;
                _fourthButton.sprite = _activeButton;
                break;
        }
    }
}
