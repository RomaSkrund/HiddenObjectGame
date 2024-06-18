using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIngrigients : MonoBehaviour
{
    private void OnMouseDrag()
    {
        gameObject.SetActive(false);
        GetetIngridientsCounter.onIngredientGeted?.Invoke();
    }
}
