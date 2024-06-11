using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactBottleAndPlace : MonoBehaviour
{
    [SerializeField] private GameObject _matchesCollider;
    [SerializeField] private GameObject _bottleSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bottle")
        {
            Destroy(collision.gameObject);
            _matchesCollider.SetActive(true);
            _bottleSprite.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
