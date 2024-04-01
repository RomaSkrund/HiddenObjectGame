using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _window;

    public void OpenWindow()
    {
        _window.SetActive(true);
    }

    public void ColseWindow()
    {
        _window.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Exit from game");
        Application.Quit();
    }
}
