using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactThornsAndItems : MonoBehaviour
{
    [SerializeField] private GameObject _thornPrefab;
    [SerializeField] private Transform _parentInventory;
    [SerializeField] private Image _sceneBG;
    [SerializeField] private Sprite _sceneWithoutThorns;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pincers")
        {
            Instantiate(_thornPrefab, _parentInventory);
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }

        if (collision.tag == "Poison")
        {
            TasksAddAndRemove.onNewTaskRemoved?.Invoke("Использовать зелье на зарослях");
            _sceneBG.sprite = _sceneWithoutThorns;
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            EndSecondLocation.onThornsDestroyed?.Invoke();
        }
    }
}
