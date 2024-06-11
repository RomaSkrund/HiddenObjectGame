using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLocksOpenChek : MonoBehaviour
{
    [SerializeField] private GameObject _crossLocksCollider;
    [SerializeField] private GameObject _crossLocksGroup;
    [SerializeField] private GameObject _doorsColliders;

    private GameObject[] _locks;

    private int _lockCount;

    private void Start()
    {
    }

    private void OnEnable()
    {
        LockLogic.onLockOpened += ChekLocks;
    }

    private void OnDisable()
    {
        LockLogic.onLockOpened -= ChekLocks;
    }

    private void ChekLocks()
    {
        _locks = GameObject.FindGameObjectsWithTag("lock");
        foreach(GameObject gameObj in _locks)
        {
            if(gameObj.GetComponent<SpriteRenderer>().enabled == true) 
            {
                _lockCount++;
            }
        }
        if (_lockCount == 0)
        {
            FinishMiniGame.onThreeDoorMiniGameEnded?.Invoke();
            _crossLocksCollider.SetActive(false);
            _crossLocksGroup.SetActive(false);
            _doorsColliders.SetActive(true);
        }
        _lockCount = 0;
    }
}
