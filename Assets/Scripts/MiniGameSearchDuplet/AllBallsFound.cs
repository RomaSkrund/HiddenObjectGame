using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBallsFound : MonoBehaviour
{
    [SerializeField] private BallsSpawner _spawner;

    private int _ballsOnScene;

    private void OnEnable()
    {
        BallsSpawner.onBallsSpawned += BallsOnScene;
        BallSpriteChanger.onBallDistroyed += AllBallsFoundChecker;
    }
    private void OnDisable()
    {
        BallsSpawner.onBallsSpawned -= BallsOnScene;
        BallSpriteChanger.onBallDistroyed -= AllBallsFoundChecker;
    }

    private void BallsOnScene()
    {
        _ballsOnScene = _spawner.StartCountOfBalls;
    }

    private void AllBallsFoundChecker()
    {
        _ballsOnScene--;
        if(_ballsOnScene == 0)
        {
            Debug.Log("End Game");
        }
    }
}
