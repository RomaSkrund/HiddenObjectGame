using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapTeleportButton : MonoBehaviour
{
    [SerializeField] private Sprite _activeButton;
    [SerializeField] private Sprite _nonActiveButton;
    [SerializeField] private GameObject _hoverLocation;
    [SerializeField] private int _sceneIndex;
    [SerializeField] private int _numberOfButton;

    private bool _isButtonActive = false;

    private void OnMouseEnter()
    {
        _hoverLocation.SetActive(true);
    }

    private void OnMouseExit()
    {
        _hoverLocation.SetActive(false);
    }

    public void Teleport()
    {
        if (_isButtonActive && SceneManager.GetActiveScene().buildIndex != _sceneIndex)
        {
            SceneManager.LoadScene(_sceneIndex);
        }
    }

    private void Update()
    {
        if(gameObject.GetComponent<Image>().sprite == _activeButton)
        {
            _isButtonActive = true;
        }
        else if (gameObject.GetComponent<Image>().sprite == _nonActiveButton)
        {
            _isButtonActive = false;
        }
    }
}
