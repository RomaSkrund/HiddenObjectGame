using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossLocksSteps : MonoBehaviour
{
    [SerializeField] private int _stepsToEnd;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _text.SetText(_stepsToEnd.ToString());
    }

    private void OnEnable()
    {
        LockLogic.onSteped += StepsCounter;
    }

    private void OnDisable()
    {
        LockLogic.onSteped -= StepsCounter;
    }

    private void StepsCounter()
    {
        _stepsToEnd--;
        if(_stepsToEnd == 0)
        {
            SceneManager.LoadScene("MiniGameCrossLocks");
        }
        _text.SetText(_stepsToEnd.ToString());
    }
}
