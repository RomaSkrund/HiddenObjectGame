using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInInventory : MonoBehaviour
{
    [SerializeField] private GameObject _chestGroup;
    
    private void OnMouseDown()
    {
        if(_chestGroup.activeSelf == true)
        {
            _chestGroup.SetActive(false);
        }
        else
        {
            _chestGroup.SetActive(true);
        }
    }
}
