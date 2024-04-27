using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKeyChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRender;

    [SerializeField] private Sprite _straightSprite;
    [SerializeField] private Sprite _upSprite;
    [SerializeField] private Sprite _upDoubleSprite;
    [SerializeField] private Sprite _downSprite;
    [SerializeField] private Sprite _downDoubleSprite;
    
    private int _keyValue;

    public int KeyValue => _keyValue;

    private void Start()
    {
        _spriteRender.sprite = _straightSprite;
        _keyValue = 0;
    }

    private void OnEnable()
    {
        if (gameObject.CompareTag("firstKey"))
        {
            UpDownButtons.onFirstKeyUpPushed += UpValueChange;
            UpDownButtons.onFirstKeyDownPushed += DownValueChange;
        }
        if (gameObject.CompareTag("secondKey"))
        {
            UpDownButtons.onSecondKeyUpPushed += UpValueChange;
            UpDownButtons.onSecondKeyDownPushed += DownValueChange;
        }
        if (gameObject.CompareTag("thirdKey"))
        {
            UpDownButtons.onThirdKeyUpPushed += UpValueChange;
            UpDownButtons.onThirdKeyDownPushed += DownValueChange;
        }
        if (gameObject.CompareTag("fourthKey"))
        {
            UpDownButtons.onFourthKeyUpPushed += UpValueChange;
            UpDownButtons.onFourthKeyDownPushed += DownValueChange;
        }
    }

    private void OnDisable()
    {
        if (gameObject.CompareTag("firstKey"))
        {
            UpDownButtons.onFirstKeyUpPushed -= UpValueChange;
            UpDownButtons.onFirstKeyDownPushed -= DownValueChange;
        }
        if (gameObject.CompareTag("secondKey"))
        {
            UpDownButtons.onSecondKeyUpPushed -= UpValueChange;
            UpDownButtons.onSecondKeyDownPushed -= DownValueChange;
        }
        if (gameObject.CompareTag("thirdKey"))
        {
            UpDownButtons.onThirdKeyUpPushed -= UpValueChange;
            UpDownButtons.onThirdKeyDownPushed -= DownValueChange;
        }
        if (gameObject.CompareTag("fourthKey"))
        {
            UpDownButtons.onFourthKeyUpPushed -= UpValueChange;
            UpDownButtons.onFourthKeyDownPushed -= DownValueChange;
        }
    }

    private void DownValueChange()
    {
        if (_keyValue == -2) return;
        _keyValue--;
        SpriteChanger();
    }

    private void UpValueChange()
    {
        if (_keyValue == 2) return;
        _keyValue++;
        SpriteChanger();
    }

    private void SpriteChanger()
    {
        switch (_keyValue)
        {
            case 2:
                _spriteRender.sprite = _upDoubleSprite;
                break;
            case 1:
                _spriteRender.sprite = _upSprite;
                break;
            case 0:
                _spriteRender.sprite = _straightSprite;
                break;
            case -1:
                _spriteRender.sprite = _downSprite;
                break;
            case -2:
                _spriteRender.sprite = _downDoubleSprite;
                break;
        }
    }
}
