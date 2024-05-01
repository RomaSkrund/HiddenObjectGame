using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockLogic : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private EdgeCollider2D _edgeCollider;

    public static Action onLockOpened;
    public static Action onSteped;

    private void Start()
    {
        _edgeCollider = GetComponent<EdgeCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _edgeCollider.enabled = false;
    }

    private void OnMouseDown()
    {
        if (_spriteRenderer.enabled == true)
        {
            _edgeCollider.enabled = true;
            onSteped?.Invoke();
        }
    }
    private void OnMouseDrag()
    { 
    }

    private void OnMouseUp()
    {
        _edgeCollider.enabled = false;
        _spriteRenderer.enabled = false;
        onLockOpened?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().enabled == false)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
