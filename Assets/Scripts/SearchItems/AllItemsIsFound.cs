using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItemsIsFound : MonoBehaviour
{
    private void OnEnable()
    {
        ClickOnItem.onTextEmptyBecomed += AllItemsFound;
    }

    private void OnDisable()
    {
        ClickOnItem.onTextEmptyBecomed -= AllItemsFound;
    }

    private void AllItemsFound()
    {
        Debug.Log("Game is end");
    }
}
