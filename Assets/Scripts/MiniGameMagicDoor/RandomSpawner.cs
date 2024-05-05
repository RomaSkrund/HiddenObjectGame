using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _signsPrefabs;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private Transform _parentSpace;

    public int SignsCount => _signsPrefabs.Length;

    private void Start()
    {
        _spawnPoints = new List<Transform>(_spawnPoints);
        SpawnSigns();
    }

    private void SpawnSigns()
    {
        foreach(GameObject gameObject in _signsPrefabs)
        {
            int randomSpawnPoint = Random.Range(0, _spawnPoints.Count);
            Instantiate(gameObject, _spawnPoints[randomSpawnPoint].transform.position, Quaternion.identity, _parentSpace);
            _spawnPoints.RemoveAt(randomSpawnPoint);
        }
    }
}
