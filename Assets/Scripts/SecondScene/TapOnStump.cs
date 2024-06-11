using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnStump : MonoBehaviour
{
    [SerializeField] private GameObject _StumpGroup;

    private void OnMouseDown()
    {
        _StumpGroup.SetActive(true);
    }
}
