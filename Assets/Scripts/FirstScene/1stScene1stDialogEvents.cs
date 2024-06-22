using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneFirstDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _characterSprite;
    [SerializeField] private GameObject _swordSprite;
    [SerializeField] private GameObject _inventoryGroup;
    [SerializeField] private GameObject _dialogeGroup;
    [SerializeField] private GameObject _getMapWindow;
    [SerializeField] private GameObject _getNotebookWindow;
    [SerializeField] private GameObject _getHintWindow;
    [SerializeField] private PolygonCollider2D _leshiyPC2D;

    private bool _isDialogActive = true;

    private void Update()
    {
        switch (_talk.NumberOfPhrase)
        {
            case 1:
                Cursor.visible = false; 
                break;
            case 2:
                _characterSprite.SetActive(true);
                break;
            case 3:
                _swordSprite.SetActive(true);
                break;
            case 5:
                _swordSprite.SetActive(false);
                break;
            case 7:
                if (_isDialogActive)
                {
                    Cursor.visible = true;
                    _inventoryGroup.SetActive(true);
                    _dialogeGroup.SetActive(false);
                    _isDialogActive = false;
                }
                break;
            case 15:
                _getMapWindow.SetActive(true);
                _leshiyPC2D.enabled = false;
                break;
            case 18:
                _getNotebookWindow.SetActive(true);
                _leshiyPC2D.enabled = false;
                break;
            case 20:
                _getHintWindow.SetActive(true);
                _leshiyPC2D.enabled = false;
                break;
            case 22:
                SceneManager.LoadScene("1stSceneSearch");
                break;
        }
    }
}
