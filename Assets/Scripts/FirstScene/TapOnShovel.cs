using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnShovel : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _bgSpriteRender;
    [SerializeField] private Sprite _spriteWhithoutShovel;

    [SerializeField] private GameObject _shovelPrefab;
    [SerializeField] private Transform _parentInventory;

    private void OnMouseDown()
    {
        _bgSpriteRender.sprite = _spriteWhithoutShovel;
        Instantiate(_shovelPrefab, _parentInventory);
        gameObject.SetActive(false);
        HintMessageSend.onHintSended?.Invoke("Если затрудняешься, как поступить, то воспользуйся подсказкой");
    }
}
