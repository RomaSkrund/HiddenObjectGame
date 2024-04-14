using UnityEngine;

public class TalkToCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _dialogGroup;

    private void OnMouseDown()
    {
        Debug.Log("onMouseDown");
        _dialogGroup.SetActive(true);
    }
}
