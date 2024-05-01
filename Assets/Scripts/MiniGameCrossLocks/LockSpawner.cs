using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _lockPrefabs;
    [SerializeField] private List<Transform> _lockSpawnPoints;
    [SerializeField] private List<Transform> _redSpawnPoints;
    [SerializeField] private Transform _parentSpace;

    private void Start()
    {
        _lockSpawnPoints = new List<Transform>(_lockSpawnPoints);
        _redSpawnPoints = new List<Transform>(_redSpawnPoints);
        SpawnSigns();
    }

    private void SpawnSigns()
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
}
