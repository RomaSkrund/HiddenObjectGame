using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveBundleGroup : MonoBehaviour
{
    public static Action onBundleInInventoryTapped;

    [SerializeField] private GameObject _bundleGroup;

    private void OnEnable()
    {
        onBundleInInventoryTapped += SetActiveGroup;
    }
    private void OnDisable()
    {
        onBundleInInventoryTapped -= SetActiveGroup;
    }

    private void SetActiveGroup()
    {
        _bundleGroup.SetActive(true);
    }
}
