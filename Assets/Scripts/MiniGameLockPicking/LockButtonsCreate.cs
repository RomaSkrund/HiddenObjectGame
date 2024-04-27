using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LockButtonsCreate : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRendererFiUp;
    [SerializeField] private SpriteRenderer _spriteRendererSeUp;
    [SerializeField] private SpriteRenderer _spriteRendererThUp;
    [SerializeField] private SpriteRenderer _spriteRendererFoUp;
    [SerializeField] private SpriteRenderer _spriteRendererFiDn;
    [SerializeField] private SpriteRenderer _spriteRendererSeDn;
    [SerializeField] private SpriteRenderer _spriteRendererThDn;
    [SerializeField] private SpriteRenderer _spriteRendererFoDn;

    [SerializeField] private Sprite _straightUp;
    [SerializeField] private Sprite _straightDown;
    [SerializeField] private Sprite _midUp;
    [SerializeField] private Sprite _midDown;
    [SerializeField] private Sprite _largeUp;
    [SerializeField] private Sprite _largeDown;

    private int _firstLock;
    private int _secondLock;
    private int _thirdLock;
    private int _fourthLock;

    public int FirstLock => _firstLock;
    public int SecondLock => _secondLock;
    public int ThirdLock => _thirdLock;
    public int FourthLock => _fourthLock;

    private void Start()
    {
        RandomizeButtonsValue();
        SetSprites(_spriteRendererFiUp, _spriteRendererFiDn, _firstLock);
        SetSprites(_spriteRendererSeUp, _spriteRendererSeDn, _secondLock);
        SetSprites(_spriteRendererThUp, _spriteRendererThDn, _thirdLock);
        SetSprites(_spriteRendererFoUp, _spriteRendererFoDn, _fourthLock);
    }

    private void RandomizeButtonsValue()
    {
        _firstLock = Random.Range(-2, 3);
        _secondLock = Random.Range(-2, 3);
        _thirdLock = Random.Range(-2, 3);
        _fourthLock = Random.Range(-2, 3);
    }

    private void SetSprites(SpriteRenderer upSprite, SpriteRenderer downSprite, int lockValue)
    {
        switch(lockValue)
        {
            case -2:
                downSprite.sprite = _straightDown;
                break;
            case -1:
                downSprite.sprite = _midDown;
                break;
            case 1:
                upSprite.sprite = _midUp;
                break;
            case 2:
                upSprite.sprite = _straightUp;
                break;
        }
    }
}
