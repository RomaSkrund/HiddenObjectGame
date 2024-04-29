using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiskRotation : MonoBehaviour
{
    [SerializeField] private Transform _largeDisk;
    [SerializeField] private Transform _mediumDisk;
    [SerializeField] private Transform _smallDisk;
    private Camera _camera;
    private float _mouseRotationZDeg;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void SearchMouseAngle()
    {
        Vector3 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _mouseRotationZDeg = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg; //-180 | 180
    }

    private void OnMouseDown()
    {

    }

    public void OnMouseDrag()
    {
        if (transform.CompareTag("LargeDisk"))
        {
            SearchMouseAngle();
            //_mediumDisk.rotation = Quaternion.Euler(0, 0, _mediumDisk.rotation.z - _mouseRotationZDeg);
            _largeDisk.rotation = Quaternion.Euler(0, 0, _mouseRotationZDeg);
        }
        //else if (transform.CompareTag("MediumDisk"))
        //{
        //    SearchMouseAngle();
        //    _largeDisk.rotation = Quaternion.Euler(0, 0, _largeDisk.rotation.z - _mouseRotationZDeg);
        //    _smallDisk.rotation = Quaternion.Euler(0, 0, _smallDisk.rotation.z - _mouseRotationZDeg);
        //    _mediumDisk.rotation = Quaternion.Euler(0, 0, _mouseRotationZDeg);
        //}
        //else
        //{
        //    _smallDisk.rotation = Quaternion.Euler(0, 0, _mouseRotationZDeg);
        //}
        
    }
}
