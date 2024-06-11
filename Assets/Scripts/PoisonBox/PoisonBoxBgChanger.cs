using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBoxBgChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _bg;
    [SerializeField] private Sprite _spriteDefault;
    [SerializeField] private Sprite _spriteWithRecipe;
    [SerializeField] private Sprite _spriteWithFire;

    private void OnEnable()
    {
        ContactRecipeAndBook.onRecipeAndBookContacted += ChangeToRecipe;
        TapOnMatches.onMatchesTapped += ChangeToFire;
        TapOnPoison.onPoisonGeted += ChangeToDefault;
    }

    private void OnDisable()
    {
        ContactRecipeAndBook.onRecipeAndBookContacted -= ChangeToRecipe;
        TapOnMatches.onMatchesTapped -= ChangeToFire;
        TapOnPoison.onPoisonGeted -= ChangeToDefault;
    }

    private void ChangeToRecipe()
    {
        _bg.sprite = _spriteWithRecipe;
    }

    private void ChangeToFire()
    {
        _bg.sprite = _spriteWithFire;
    }

    private void ChangeToDefault()
    {
        _bg.sprite = _spriteDefault;
    }
}
