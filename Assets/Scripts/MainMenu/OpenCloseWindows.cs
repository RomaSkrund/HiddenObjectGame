using UnityEngine;

public class OpenCloseWindows : MonoBehaviour
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
}
