using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMiniGame : MonoBehaviour
{
    [SerializeField] private GameObject _miniGameGroup;
    [SerializeField] private GameObject _doorCollidersGroup;

    public void ColseMiniGame()
    {
        _miniGameGroup.SetActive(false);
        _doorCollidersGroup.SetActive(true);
    }
}
