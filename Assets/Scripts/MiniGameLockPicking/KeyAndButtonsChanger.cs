using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAndButtonsChanger : MonoBehaviour
{
    [SerializeField] private Transform _upBtn;
    [SerializeField] private Transform _downBtn;

    [SerializeField] private SpriteRenderer _key;
    
    [SerializeField] private MasterKeyChanger _masterMasterKey;

    [SerializeField] private Sprite _straightSprite;
    [SerializeField] private Sprite _upSprite;
    [SerializeField] private Sprite _upDoubleSprite;
    [SerializeField] private Sprite _downSprite;
    [SerializeField] private Sprite _downDoubleSprite;

    [SerializeField] private float _upTwoButton = 1.83f;
    [SerializeField] private float _upOneButton = 1.4f;
    [SerializeField] private float _upStraightButton = 0.95f;
    [SerializeField] private float _downStraightButton = -0.92f;
    [SerializeField] private float _downOneButton = -1.38f;
    [SerializeField] private float _downTwoButton = -1.8f;

    private void Update()
    {
        ChangeKey();
    }

    private void ChangeKey()
    {
        switch (_masterMasterKey.KeyValue)  
        {
            case 2:
                _upBtn.transform.position = new Vector3(_upBtn.position.x, _upTwoButton, _upBtn.position.z);
                _downBtn.transform.position = new Vector3(_downBtn.position.x, _downStraightButton, _downBtn.position.z);
                _key.sprite = _upDoubleSprite;
                break;
            case 1:
                _upBtn.transform.position = new Vector3(_upBtn.position.x, _upOneButton, _upBtn.position.z);
                _downBtn.transform.position = new Vector3(_downBtn.position.x, _downStraightButton, _downBtn.position.z);
                _key.sprite = _upSprite;
                break;
            case 0:
                _upBtn.transform.position = new Vector3(_upBtn.position.x, _upStraightButton, _upBtn.position.z);
                _downBtn.transform.position = new Vector3(_downBtn.position.x, _downStraightButton, _downBtn.position.z);
                _key.sprite = _straightSprite;
                break;
            case -1:
                _upBtn.transform.position = new Vector3(_upBtn.position.x, _upStraightButton, _upBtn.position.z);
                _downBtn.transform.position = new Vector3(_downBtn.position.x, _downOneButton, _downBtn.position.z);
                _key.sprite = _downSprite;
                break;
            case -2:
                _upBtn.transform.position = new Vector3(_upBtn.position.x, _upStraightButton, _upBtn.position.z);
                _downBtn.transform.position = new Vector3(_downBtn.position.x, _downTwoButton, _downBtn.position.z);
                _key.sprite = _downDoubleSprite;
                break;
        }
    }
}
