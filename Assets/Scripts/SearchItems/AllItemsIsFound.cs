using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItemsIsFound : MonoBehaviour
{
    [SerializeField] private GameObject _searchItemsGroup;
    [SerializeField] private GameObject _getChestGroup;
    [SerializeField] private GameObject _poisonBoxUI;
    [SerializeField] private GameObject _searchDupletUI;

    private void OnEnable()
    {
        AllBallsFound.onBallsFouned += AllItemsFound;
        ClickOnItem.onTextEmptyBecomed += AllItemsFound;
        AllBallsFound.onBallsFouned += AllItemsFound;
    }

    private void OnDisable()
    {
        AllBallsFound.onBallsFouned -= AllItemsFound;
        ClickOnItem.onTextEmptyBecomed -= AllItemsFound;
        AllBallsFound.onBallsFouned -= AllItemsFound;
    }

    private void AllItemsFound()
    {
        _searchItemsGroup.SetActive(false);
        _getChestGroup.SetActive(true);
        _poisonBoxUI.SetActive(true);
        _searchDupletUI.SetActive(false);
    }
}
