using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDirtWithShovel : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _bgRenderer;
    [SerializeField] private Sprite _spriteDiggedDirt;
    [SerializeField] private GameObject _wormAndRootCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shovel")
        {
            _bgRenderer.sprite = _spriteDiggedDirt;
            gameObject.SetActive(false);
            _wormAndRootCollider.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
