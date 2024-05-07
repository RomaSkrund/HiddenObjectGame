using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnHollow : MonoBehaviour
{
    [SerializeField] private GameObject _hollowGroup;

    private void OnMouseDown()
    {
        _hollowGroup.SetActive(true);
    }
}
