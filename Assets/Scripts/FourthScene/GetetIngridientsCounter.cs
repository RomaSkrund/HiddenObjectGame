using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetetIngridientsCounter : MonoBehaviour
{
    public static Action onIngredientGeted;

    [SerializeField] private PolygonCollider2D _talkToCharacterCollrider;

    private int _ingredientsCount = 0;

    private void OnEnable()
    {
        onIngredientGeted += GetIngredient;
    }

    private void OnDisable()
    {
        onIngredientGeted -= GetIngredient;
    }

    private void OnMouseDown()
    {
        HintMessageSend.onHintSended?.Invoke("Найдены не все ингредиенты");
    }

    private void GetIngredient() 
    {
        _ingredientsCount++;
        if(_ingredientsCount == 4)
        {
            _talkToCharacterCollrider.enabled = true;
            gameObject.SetActive(false);
        }
    }
}
