using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourthSceneDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _characterSprite;
    [SerializeField] private GameObject _dialogeGroup;
    [SerializeField] private GameObject _getfirstKeyWindow;
    [SerializeField] private Image _BG;
    [SerializeField] private Sprite _threeDoorBG;
    [SerializeField] private Sprite _tableWithoutIngridients;
    [SerializeField] private GameObject _ingridientsGroup;
    [SerializeField] private PolygonCollider2D _talkToCharacterCollrider;
    [SerializeField] private GameObject _yagaCollider;
    [SerializeField] private GameObject _miniGameBoilerGroup;


    private bool _isItemGet = false;
    private bool _event14Done = false;
    private bool _event16Done = false;

    private void Update()
    {
        switch (_talk.NumberOfPhrase)
        {
            case 7:
                _BG.sprite = _threeDoorBG;
                break;
            case 10:
                if (!_isItemGet)
                {
                    _characterSprite.SetActive(false);
                    _dialogeGroup.SetActive(false);
                    _getfirstKeyWindow.SetActive(true);
                    _isItemGet = true;
                    TasksAddAndRemove.onNewTaskAdded?.Invoke("Открыть все двери");
                }
                break;
            case 14:
                if (!_event14Done)
                {
                    _talkToCharacterCollrider.enabled = false;
                    _yagaCollider.SetActive(true);
                    _dialogeGroup.SetActive(false);
                    _BG.sprite = _tableWithoutIngridients;
                    _ingridientsGroup.SetActive(true);
                    _event14Done = true;
                }
                break;
            case 16:
                if (!_event16Done)
                {
                    _characterSprite.SetActive(false);
                    _dialogeGroup.SetActive(false);
                    _miniGameBoilerGroup.SetActive(true);
                    MiniGameUIActivated.onMiniGameActivated?.Invoke(4);
                    _event16Done = true;
                }
                break;
            case 19:
                _characterSprite.SetActive(false);
                _dialogeGroup.SetActive(false);
                FinalVideo.onFinalSceneStarted?.Invoke();
                break;
        }
    }

}
