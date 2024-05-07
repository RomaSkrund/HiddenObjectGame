using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBirdInHollow : MonoBehaviour
{
    [SerializeField] private GameObject _rightBushCollider;
    [SerializeField] private ParticleSystem _secondParticle;

    private bool _isParticleBeenStarted = false;
    private bool _isTaskAdded = false;

    private void OnMouseDown()
    {
        HintMessageSend.onHintSended?.Invoke("Там в дупле что-то есть, но птица не пускает… Наверное, она голодна");
        if (!_isTaskAdded)
        {
            TasksAddAndRemove.onNewTaskAdded?.Invoke("Забрать жетон-ключ у птицы");
            _isTaskAdded = true;
        }
        _rightBushCollider.SetActive(true);

        if (!_isParticleBeenStarted)
        {
            _secondParticle.Play();
            _isParticleBeenStarted = true;
        }
    }
}
