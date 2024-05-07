using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInventoryItem : MonoBehaviour
{
    private Vector3 _defaultPosition;

    private void OnMouseDown()
    {
        _defaultPosition = gameObject.transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }

    private void OnMouseUp()
    {
        gameObject.transform.position = _defaultPosition;
    }
}
