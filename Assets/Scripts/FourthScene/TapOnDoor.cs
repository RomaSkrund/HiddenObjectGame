using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnDoor : MonoBehaviour
{
    [SerializeField] private ContactKeyWithDoor _contactKeyWithDoor;
    [SerializeField] private GameObject _miniGameGroup;
    [SerializeField] private GameObject _doorCollidersGroup;
    [SerializeField] private int _numberOfMiniGame;

    private void OnMouseDown()
    {
        if(_contactKeyWithDoor.DoorIsOpen == true)
        {
            MiniGameUIActivated.onMiniGameActivated?.Invoke(_numberOfMiniGame);
            _miniGameGroup.SetActive(true);
            _doorCollidersGroup.SetActive(false);
        }
        else
        {
            HintMessageSend.onHintSended?.Invoke("ƒверь заперта, нужно попробовать использовать предмет, данный Ѕабой ягой");
        }
    }
}
