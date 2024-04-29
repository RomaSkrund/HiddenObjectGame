using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SearchDuplet : MonoBehaviour
{
    public static Action<string> onDupletSearched;
    public static Action<string, string> onNonDupletSearched;
    public static Action onSeekSingsAdded;

    private string _firstSignName = null;
    private string _secondSignName = null;
    private Vector3 _firstSignPosition = Vector3.zero;
    private Vector3 _secondSignPosition = Vector3.zero;

    private int _seekSignCount = 0;
    public int SeekSignCount => _seekSignCount;

    private void OnEnable()
    {
        SignSpriteChanger.onSignPushed += CompareSigns;
    }

    private void OnDisable()
    {
        SignSpriteChanger.onSignPushed -= CompareSigns;
    }

    private void CompareSigns(string signName, Vector3 signPosition)
    {
        if(_firstSignName == null)
        {
            _firstSignName = signName;
            _firstSignPosition = signPosition;
        }
        else if(_secondSignName == null)
        {
            _secondSignName = signName;
            _secondSignPosition = signPosition;
            if(_firstSignName == _secondSignName && _firstSignPosition != _secondSignPosition)
            {
                onDupletSearched?.Invoke(signName);
                ClearSigns();
                _seekSignCount += 2;
                onSeekSingsAdded?.Invoke();
            }
            else
            {
                onNonDupletSearched?.Invoke(_firstSignName, _secondSignName);
                ClearSigns();
            }
        }
    }

    private void ClearSigns()
    {
        _firstSignName = null;
        _secondSignName = null;
        _firstSignPosition = Vector3.zero;
        _secondSignPosition = Vector3.zero;
    }
}
