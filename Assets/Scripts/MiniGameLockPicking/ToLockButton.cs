using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToLockButton : MonoBehaviour
{
    [SerializeField] private GameObject _masterKeyGroup;
    [SerializeField] private GameObject _lockKeyGroup;

    public static Action onToLeftButtonPushed;

    public void ToLock()
    {
        onToLeftButtonPushed?.Invoke();
        _masterKeyGroup.SetActive(false);
        _lockKeyGroup.SetActive(true);
    }
}
