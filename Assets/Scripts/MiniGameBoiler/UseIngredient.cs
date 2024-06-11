using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UseIngredient : MonoBehaviour
{
    [SerializeField] private int _numberOfSign;
    [SerializeField] private int _numberOfIngredient;

    public static Action onQueueMoved;

    private int _queueOfIngredients = 1;
    private int _numberOfCircleSign = 0;

    private void OnEnable()
    {
        onQueueMoved += MoveQueue;
        TapOnSignCircle.onSignCircleTapped += TryToUseIngredient;
    }

    private void OnDisable()
    {
        TapOnSignCircle.onSignCircleTapped -= TryToUseIngredient;
        onQueueMoved -= MoveQueue;
    }

    private void TryToUseIngredient(int numberOfSign)
    {
        _numberOfCircleSign = numberOfSign;
    }

    private void OnMouseDown()
    {
        if (_numberOfSign == _numberOfCircleSign && _queueOfIngredients == _numberOfIngredient)
        {
            PlayVideoBoiler.onVideoPlayed?.Invoke(_numberOfIngredient);
            onQueueMoved?.Invoke();
            gameObject.SetActive(false);
            if(_numberOfIngredient == 4)
            {
                TapOnBoiler.onIngredientsAdded?.Invoke();
            }
        }
    }

    private void MoveQueue()
    {
        _queueOfIngredients++;
    }
}
