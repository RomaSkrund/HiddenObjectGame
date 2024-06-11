using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ContactRecipeAndBook : MonoBehaviour
{
    [SerializeField] private GameObject _matchesCollider;

    public static Action onRecipeAndBookContacted;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Recipe")
        {
            Destroy(collision.gameObject);
            _matchesCollider.SetActive(true);
            gameObject.SetActive(false);
            onRecipeAndBookContacted?.Invoke();
        }
    }
}
