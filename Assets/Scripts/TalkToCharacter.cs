using UnityEngine;

public class TalkToCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _dialogGroup;

    private void OnMouseDown()
    {
        _dialogGroup.SetActive(true);
    }
}
