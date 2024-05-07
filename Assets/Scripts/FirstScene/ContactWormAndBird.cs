using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactWormAndBird : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _woodSpriteRenderer;
    [SerializeField] private Sprite _hollowWithoutBird;
    [SerializeField] private GameObject _stoneKeyCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Worm")
        {
            _woodSpriteRenderer.sprite = _hollowWithoutBird;
            _stoneKeyCollider.SetActive(true);
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            TasksAddAndRemove.onNewTaskRemoved("Забрать жетон-ключ у птицы");
        }
    }
}
