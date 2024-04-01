using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskRotation : MonoBehaviour
{
    [SerializeField] private Transform _largeDisk;
    [SerializeField] private Transform _mediumDisk;
    [SerializeField] private Transform _smallDisk;
    private Camera _camera;
    private float _mouseRotationZ;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void SearchMouseAngle()
    {
        Vector3 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _mouseRotationZ = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
    }

    public void OnMouseDrag()
    {
        if (transform.CompareTag("LargeDisk"))
        {
            SearchMouseAngle();
            _mediumDisk.rotation = Quaternion.Euler(0, 0, _mediumDisk.rotation.z - _mouseRotationZ);
            _largeDisk.rotation = Quaternion.Euler(0, 0, _mouseRotationZ);
        }
        else if (transform.CompareTag("MediumDisk"))
        {
            SearchMouseAngle();
            _largeDisk.rotation = Quaternion.Euler(0, 0, _largeDisk.rotation.z - _mouseRotationZ);
            _smallDisk.rotation = Quaternion.Euler(0, 0, _smallDisk.rotation.z - _mouseRotationZ);
            _mediumDisk.rotation = Quaternion.Euler(0, 0, _mouseRotationZ);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, _mouseRotationZ);
        }
        
    }
}
