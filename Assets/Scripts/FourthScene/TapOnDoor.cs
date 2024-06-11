using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnDoor : MonoBehaviour
{
    [SerializeField] private ContactKeyWithDoor _contactKeyWithDoor;
    [SerializeField] private GameObject _miniGameGroup;
    [SerializeField] private GameObject _doorCollidersGroup;

    private void OnMouseDown()
    {
        if(_contactKeyWithDoor.DoorIsOpen == true)
        {
            _miniGameGroup.SetActive(true);
            _doorCollidersGroup.SetActive(false);
        }
        else
        {
            HintMessageSend.onHintSended?.Invoke("ƒверь заперта, нужно попробовать использовать предмет, данный Ѕабой ягой");
        }
    }
}
