using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _lockPrefabs;
    [SerializeField] private List<Transform> _lockSpawnPoints;
    [SerializeField] private List<Transform> _redSpawnPoints;
    [SerializeField] private Transform _parentSpace;

    public static Action onGameRestarted;

    private void Start()
    {
        _lockSpawnPoints = new List<Transform>(_lockSpawnPoints);
        _redSpawnPoints = new List<Transform>(_redSpawnPoints);
        SpawnLocks();
    }

    private void OnEnable()
    {
        onGameRestarted += RespawnLocks;
    }

    private void OnDisable()
    {
        onGameRestarted -= RespawnLocks;
    }

    private void SpawnLocks()
    {
        foreach (Transform spawnPoint in _lockSpawnPoints)
        {
            Instantiate(_lockPrefabs, spawnPoint.transform.position, Quaternion.identity, _parentSpace);
        }
        foreach (Transform spawnPoint in _redSpawnPoints)
        {
            GameObject field = Instantiate(_lockPrefabs, spawnPoint.transform.position, Quaternion.identity, _parentSpace);
            field.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void DestroyOldLocks()
    {
        GameObject[] oldLocks = GameObject.FindGameObjectsWithTag("lock");
        foreach(GameObject oldLock in oldLocks)
        {
            Destroy(oldLock);
        }
    }

    private void RespawnLocks()
    {
        DestroyOldLocks();
        SpawnLocks();
    }
}
