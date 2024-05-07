using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactChestWithKey : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _chestSpriteRenderer;
    [SerializeField] private Sprite _chestWithStone;
    [SerializeField] private Sprite _openChest;
    [SerializeField] private GameObject _paperCollider;

    private bool _isKeyInChest = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "StoneKey")
        {
            _chestSpriteRenderer.sprite = _chestWithStone;
            _isKeyInChest = true;
            Destroy(collision.gameObject);
        }
    }

    private void OnMouseDown()
    {
        if(_isKeyInChest) 
        {
            _chestSpriteRenderer.sprite = _openChest;
            gameObject.SetActive(false);
            _paperCollider.SetActive(true);
            TasksAddAndRemove.onNewTaskRemoved?.Invoke("Открыть шкатулку");
        }
    }

}
