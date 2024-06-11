using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class DiskSpriteChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _diskSR;
    [SerializeField] private Sprite _activeSprite;
    [SerializeField] private Sprite _nonActiveSprite;

    public static Action<string> onDiskActivated;

    private void OnMouseDown()
    {
        onDiskActivated?.Invoke(tag);
        _diskSR.sprite = _activeSprite;
    }

    private void OnEnable()
    {
        onDiskActivated += DisactivateOtherDisks;
    }

    private void OnDisable()
    {
        onDiskActivated -= DisactivateOtherDisks;
    }

    private void DisactivateOtherDisks(string diskTag)
    {
        switch (diskTag)
        {
            case ("LargeDisk"):
                if (tag == "MediumDisk") _diskSR.sprite = _nonActiveSprite;
                if (tag == "SmallDisk") _diskSR.sprite = _nonActiveSprite;
                break;
            case ("MediumDisk"):
                if (tag == "LargeDisk") _diskSR.sprite = _nonActiveSprite;
                if (tag == "SmallDisk") _diskSR.sprite = _nonActiveSprite;
                break;
            case ("SmallDisk"):
                if (tag == "LargeDisk") _diskSR.sprite = _nonActiveSprite;
                if (tag == "MediumDisk") _diskSR.sprite = _nonActiveSprite;
                break;
        }
    }
}
