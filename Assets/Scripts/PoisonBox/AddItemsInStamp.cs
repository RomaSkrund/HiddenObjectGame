using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemsInStamp : MonoBehaviour
{
    [SerializeField] private GameObject _canCollider;

    private int _itemOrderCounter = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Thorn" && _itemOrderCounter == 0)
        {
            Destroy(collision.gameObject);
            PoisonVideoPlayer.onVideoPlayed?.Invoke(2);
            _itemOrderCounter++;
        }
        if (collision.tag == "Berries" && _itemOrderCounter == 1)
        {
            Destroy(collision.gameObject);
            PoisonVideoPlayer.onVideoPlayed?.Invoke(3);
            _itemOrderCounter++;
        }
        if (collision.tag == "Powder" && _itemOrderCounter == 2)
        {
            Destroy(collision.gameObject);
            PoisonVideoPlayer.onVideoPlayed?.Invoke(4);
            _itemOrderCounter++;
        }
        if (collision.tag == "Stick" && _itemOrderCounter == 3)
        {
            Destroy(collision.gameObject);
            PoisonVideoPlayer.onVideoPlayed?.Invoke(5);
            _itemOrderCounter++;
            _canCollider.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
