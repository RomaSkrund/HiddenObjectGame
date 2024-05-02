using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupletBalls : MonoBehaviour
{
    public static Action<string> onDupletBallsSearched;
    public static Action<string, string> onNonDupletBallsSearched;

    private string _firstBallName = null;
    private string _secondBallName = null;
    private Vector3 _firstBallPosition = Vector3.zero;
    private Vector3 _secondBallPosition = Vector3.zero;

    private void OnEnable()
    {
        BallSpriteChanger.onBallPushed += CompareBalls;
    }

    private void OnDisable()
    {
        SignSpriteChanger.onSignPushed -= CompareBalls;
    }

    private void CompareBalls(string ballName, Vector3 ballPosition)
    {
        if (_firstBallName == null)
        {
            _firstBallName = ballName;
            _firstBallPosition = ballPosition;
        }
        else if (_secondBallName == null)
        {
            _secondBallName = ballName;
            _secondBallPosition = ballPosition;
            if (_firstBallName == _secondBallName && _firstBallPosition != _secondBallPosition)
            {
                onDupletBallsSearched?.Invoke(ballName);
                ClearBalls();
            }
            else
            {
                onNonDupletBallsSearched?.Invoke(_firstBallName, _secondBallName);
                ClearBalls();
            }
        }
    }

    private void ClearBalls()
    {
        _firstBallName = null;
        _secondBallName = null;
        _firstBallPosition = Vector3.zero;
        _secondBallPosition = Vector3.zero;
    }

}
