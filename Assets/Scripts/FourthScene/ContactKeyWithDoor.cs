using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactKeyWithDoor : MonoBehaviour
{
    [SerializeField] private GameObject _miniGameGroup;
    [SerializeField] private string _tagOfKey;
    [SerializeField] private GameObject _doorCollidersGroup;
    [SerializeField] private int _numberOfMiniGame;

    private bool _doorIsOpen = false;

    public bool DoorIsOpen => _doorIsOpen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == _tagOfKey)
        {
            Destroy(collision.gameObject);
            _doorIsOpen = true;
            _miniGameGroup.SetActive(true);
            _doorCollidersGroup.SetActive(false);
            MiniGameUIActivated.onMiniGameActivated?.Invoke(_numberOfMiniGame);
        }
    }
}
