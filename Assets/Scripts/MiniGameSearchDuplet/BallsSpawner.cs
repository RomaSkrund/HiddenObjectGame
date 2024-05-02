using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _ballsPrefabs;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Transform _parentSpace;

    public static Action onBallsSpawned;

    private int _startCountOfBalls = 0;

    public int StartCountOfBalls => _startCountOfBalls;

    private void Start()
    {
        _spawnPoints = new List<Transform>(_spawnPoints);
        SpawnBalls();
        onBallsSpawned?.Invoke();
    }

    private void SpawnBalls()
    {
        foreach (GameObject gameObject in _ballsPrefabs)
        {
            int randomSpawnPoint = UnityEngine.Random.Range(0, _spawnPoints.Count);
            Instantiate(gameObject, _spawnPoints[randomSpawnPoint].transform.position, Quaternion.identity, _parentSpace);
            _spawnPoints.RemoveAt(randomSpawnPoint);
            _startCountOfBalls++;
        }
    }
}
