using System.Runtime.CompilerServices;
using UnityEngine;

public class FirstSceneFirstDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _characterSprite;
    [SerializeField] private GameObject _swordSprite;
    [SerializeField] private GameObject _inventoryGroup;
    [SerializeField] private GameObject _dialogeGroup;

    private bool _isDialogActive = true;

    private void Update()
    {
        if (_talk.NumberOfPhrase == 2)
            _characterSprite.SetActive(true);

        if(_talk.NumberOfPhrase == 3)
            _swordSprite.SetActive(true);

        if (_talk.NumberOfPhrase == 5)
            _swordSprite.SetActive(false);

        if (_talk.NumberOfPhrase == 7 && _isDialogActive == true)
        {
            _inventoryGroup.SetActive(true);
            _dialogeGroup.SetActive(false);
            _isDialogActive = false;
        }
    }
}
