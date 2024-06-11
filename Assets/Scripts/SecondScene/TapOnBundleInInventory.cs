using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBundleInInventory : MonoBehaviour
{
    private void OnMouseDown()
    {
        SetActiveBundleGroup.onBundleInInventoryTapped?.Invoke();
        Destroy(gameObject);
    }
}
