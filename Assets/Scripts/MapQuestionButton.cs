using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapQuestionButton : MonoBehaviour
{
    [SerializeField] private GameObject _questionGroup;

    private bool _isQuestGroupActive = false;

    public void QuestionButton()
    {
        if (!_isQuestGroupActive)
        {
            _questionGroup.SetActive(true);
            _isQuestGroupActive = true;
        }
        else
        {
            _questionGroup.SetActive(false);
            _isQuestGroupActive = false;
        }
    }
}
