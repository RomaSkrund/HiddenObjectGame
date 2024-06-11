using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondSceneDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _characterSprite;
    [SerializeField] private GameObject _dialogeGroup;
    [SerializeField] private GameObject _getPowderWindow;
    [SerializeField] private GameObject _stumpCollider;
    [SerializeField] private GameObject _nearToSumpCollider;

    private bool _isCaseWorekd = false;

    private void Update()
    {
        switch (_talk.NumberOfPhrase)
        {
            case 2:
                _characterSprite.SetActive(true);
                break;
            case 6:
                if(_isCaseWorekd == false)
                {
                    _characterSprite.SetActive(false);
                    _dialogeGroup.SetActive(false);
                    _getPowderWindow.SetActive(true);
                    _stumpCollider.SetActive(true);
                    _nearToSumpCollider.SetActive(true);
                    _isCaseWorekd = true;
                }
                break;
        }
    }

}
