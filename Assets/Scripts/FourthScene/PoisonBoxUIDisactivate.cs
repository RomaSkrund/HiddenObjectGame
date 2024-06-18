using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBoxUIDisactivate : MonoBehaviour
{
    [SerializeField] private GameObject _poisonBoxUI;

    private void Start()
    {
        _poisonBoxUI.SetActive(false);
    }
}
