using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateThreeDoorsColliders : MonoBehaviour
{
    [SerializeField] private GameObject _doorsCollidersGroup;

    private void OnMouseDown()
    {
        _doorsCollidersGroup.SetActive(true);
    }
}
