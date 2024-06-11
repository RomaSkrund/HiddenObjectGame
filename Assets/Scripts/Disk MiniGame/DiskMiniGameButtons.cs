using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMiniGameButtons : MonoBehaviour
{
    [SerializeField] private Transform _largeDisk;
    [SerializeField] private Transform _mediumDisk;
    [SerializeField] private Transform _smallDisk;
    [SerializeField] private float _rotateValue = 5;

    private string _tagActiveDisk;

    private bool _upPush = false;
    private bool _downPush = false;

    private void OnEnable()
    {
        DiskSpriteChanger.onDiskActivated += ActualDiskTag;
    }

    private void OnDisable()
    {
        DiskSpriteChanger.onDiskActivated -= ActualDiskTag; 
    }

    private void ActualDiskTag(string tag)
    {
        _tagActiveDisk = tag;
    }

    public void UpButtonPush(bool up)
    {
        _upPush = up;
        AllDiskInRightPosition.onDiskPositionChanged?.Invoke();
    }

    public void DownButtonPush(bool down)
    {
        _downPush = down;
        AllDiskInRightPosition.onDiskPositionChanged?.Invoke();
    }

    private void RotateDisks(int sign)
    {
        if (_tagActiveDisk == "LargeDisk")
        {
            _largeDisk.Rotate(0, 0, _rotateValue * sign);
            _mediumDisk.Rotate(0, 0, -(_rotateValue * sign));
        }
        else if (_tagActiveDisk == "MediumDisk")
        {
            _largeDisk.Rotate(0, 0, -(_rotateValue * sign));
            _smallDisk.Rotate(0, 0, -(_rotateValue * sign));
            _mediumDisk.Rotate(0, 0, _rotateValue * sign);
        }
        else if (_tagActiveDisk == "SmallDisk")
        {
            _smallDisk.Rotate(0, 0, _rotateValue * sign);
        }
    }

    private void FixedUpdate()
    {
        if (_upPush) RotateDisks(1);
        if (_downPush) RotateDisks(-1);
    }
}
