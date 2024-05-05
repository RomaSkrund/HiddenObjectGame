using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItemsIsFound : MonoBehaviour
{
    [SerializeField] private GameObject _searchItemsGroup;
    [SerializeField] private GameObject _searchDuplet;
    [SerializeField] private GameObject _getChestGroup;

    private void OnEnable()
    {
        ClickOnItem.onTextEmptyBecomed += AllItemsFound;
        AllBallsFound.onBallsFouned += AllItemsFound;
    }

    private void OnDisable()
    {
        ClickOnItem.onTextEmptyBecomed -= AllItemsFound;
        AllBallsFound.onBallsFouned -= AllItemsFound;
    }

    private void AllItemsFound()
    {
        _searchItemsGroup.SetActive(false);
        _searchDuplet.SetActive(false);
        _getChestGroup.SetActive(true);
    }
}
