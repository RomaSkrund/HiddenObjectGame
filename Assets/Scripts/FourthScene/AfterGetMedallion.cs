using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfterGetMedallion : MonoBehaviour
{
    [SerializeField] private Image _houseBG;
    [SerializeField] private Sprite _houseTable;
    [SerializeField] private GameObject _babaYaga;
    [SerializeField] private GameObject _getMedallionWindow;
    [SerializeField] private GameObject _chestGroup;

    private void OnMouseDown()
    {
        _houseBG.sprite = _houseTable;
        _babaYaga.SetActive(true);
        _chestGroup.SetActive(false);
        _getMedallionWindow.SetActive(true);
    }
}
