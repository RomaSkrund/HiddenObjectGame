using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLeshiyCollider : MonoBehaviour
{
    [SerializeField] private PolygonCollider2D _leshiyPC2D;

    private void OnMouseDown()
    {
        _leshiyPC2D.enabled = true;
    }
}
