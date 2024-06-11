using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFinalPoison : MonoBehaviour
{
    [SerializeField] private GameObject _miniGameBoilerGroup;
    [SerializeField] private GameObject _yagaSprite;
    [SerializeField] private GameObject _dialogWindow;
    [SerializeField] private GameObject _UI;

    private void OnMouseDown()
    {
        _miniGameBoilerGroup.SetActive(false);
        _yagaSprite.SetActive(true);
        _dialogWindow.SetActive(true);
        _UI.SetActive(false);
    }
}
