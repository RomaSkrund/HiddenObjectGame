using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnSignCircle : MonoBehaviour
{
    [SerializeField] private Transform _arrow;

    private int _numberOfSign = 3;

    public static Action<int> onSignCircleTapped;

    private void OnMouseDown()
    {
        _numberOfSign++;
        if (_numberOfSign == 5) _numberOfSign = 1;
        _arrow.Rotate(0, 0, -90);
        onSignCircleTapped?.Invoke(_numberOfSign);
    }
}
