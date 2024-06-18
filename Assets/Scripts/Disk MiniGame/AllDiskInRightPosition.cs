using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AllDiskInRightPosition : MonoBehaviour
{
    [SerializeField] private GameObject _disksGroup;
    [SerializeField] private GameObject _disksDoorCollider;
    [SerializeField] private GameObject _doorsColliders;

    [SerializeField] private Transform _largeDisk;
    [SerializeField] private Transform _mediumDisk;
    [SerializeField] private Transform _smallDisk;
    [SerializeField] private int[] _rotationSpread = { -2, -1, 0, 1, 2 };

    public static Action onDiskPositionChanged;

    private bool _largeDiskInPosition = false;
    private bool _middleDiskInPosition = false;
    private bool _smallDiskInPosition = false;

    private void OnEnable()
    {
        MiniGameSkip.onSkipButtonPushed += EndMiniGame;
        onDiskPositionChanged += ChekForDiskPoistion;
    }

    private void OnDisable()
    {
        MiniGameSkip.onSkipButtonPushed -= EndMiniGame;
        onDiskPositionChanged -= ChekForDiskPoistion;
    }

    private void ChekForDiskPoistion()
    {
        foreach(var angle in _rotationSpread)
        {
            if ((int)_largeDisk.transform.rotation.eulerAngles.z == angle) 
            {
                _largeDiskInPosition = true;
            }
            if ((int)_mediumDisk.transform.rotation.eulerAngles.z == angle)
            {
                _middleDiskInPosition = true;
            }
            if ((int)_smallDisk.transform.rotation.eulerAngles.z == angle)
            {
                _smallDiskInPosition = true;
            }
        }
        if(_largeDiskInPosition && _middleDiskInPosition && _smallDiskInPosition)
        {
            EndMiniGame();
        }
        _largeDiskInPosition = false;
        _middleDiskInPosition = false;
        _smallDiskInPosition = false;
    }

    private void EndMiniGame()
    {
        FinishMiniGame.onThreeDoorMiniGameEnded?.Invoke();
        _disksDoorCollider.SetActive(false);
        _disksGroup.SetActive(false);
        _doorsColliders.SetActive(true);
        MiniGameUIActivated.onMiniGameDisactivated?.Invoke(3);
    }
}
