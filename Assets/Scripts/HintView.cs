using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HintView : MonoBehaviour
{
    [SerializeField] private GameObject _hintWindow;
    [SerializeField] private Text _hintText;

    private void OnEnable()
    {
        HintMessageSend.onHintSended += ShowHint;
    }

    private void OnDisable()
    {
        HintMessageSend.onHintSended -= ShowHint;
    }

    private void ShowHint(string hint)
    {
        _hintWindow.SetActive(true);
        _hintText.text = hint;
        Invoke(nameof(HideHint), 3f);
    }

    private void HideHint()
    {
        _hintWindow.SetActive(false);
    }
}
