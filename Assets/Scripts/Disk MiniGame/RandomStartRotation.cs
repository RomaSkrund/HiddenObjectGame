using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartRotation : MonoBehaviour
{
    [SerializeField] private Transform _largeDisk;
    [SerializeField] private Transform _mediumDisk;
    [SerializeField] private Transform _smallDisk;

    private int _rotation;

    private void Start()
    {
        _rotation = Random.Range(-180, 180);
        _largeDisk.Rotate(0, 0, _rotation);
        _mediumDisk.Rotate(0, 0, -_rotation);
        _smallDisk.Rotate(0, 0, Random.Range(-180, 180));
    }
}
