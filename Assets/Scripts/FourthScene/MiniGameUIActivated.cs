using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameUIActivated : MonoBehaviour
{
    [SerializeField] private GameObject _inventory;
    [SerializeField] private GameObject _hintGroup;
    [SerializeField] private GameObject _poisonBoxGroup;
    [SerializeField] private GameObject _firstMiniGameGroup;
    [SerializeField] private GameObject _secondMiniGameGroup;
    [SerializeField] private GameObject _thirdMiniGameGroup;
    [SerializeField] private GameObject _fourMiniGameGroup;

    public static Action<int> onMiniGameActivated;
    public static Action<int> onMiniGameDisactivated;

    private void OnEnable()
    {
        onMiniGameActivated += ActivateUI;
        onMiniGameDisactivated += DisactivateUI;
    }

    private void OnDisable()
    {
        onMiniGameActivated -= ActivateUI;
        onMiniGameDisactivated -= DisactivateUI;
    }

    private void ActivateUI(int numberOfMiniGame)
    {

        switch (numberOfMiniGame)
        {
            case 1:
                _firstMiniGameGroup.SetActive(true);
                break;
            case 2:
                _secondMiniGameGroup.SetActive(true);
                break;
            case 3:
                _thirdMiniGameGroup.SetActive(true);
                break;
            case 4:
                _fourMiniGameGroup.SetActive(true);
                break;

        }

        _inventory.SetActive(false);
        _hintGroup.SetActive(false);
        _poisonBoxGroup.SetActive(false);
    }

    private void DisactivateUI(int numberOfMiniGame)
    {
        switch (numberOfMiniGame)
        {
            case 1:
                _firstMiniGameGroup.SetActive(false);
                break;
            case 2:
                _secondMiniGameGroup.SetActive(false);
                break;
            case 3:
                _thirdMiniGameGroup.SetActive(false);
                break;
            case 4:
                _fourMiniGameGroup.SetActive(false);
                break;
        }

        _inventory.SetActive(true);
        _hintGroup.SetActive(true);
        _poisonBoxGroup.SetActive(true);
    }
}
