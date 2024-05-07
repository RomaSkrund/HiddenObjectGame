using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnRightBush : MonoBehaviour
{
    [SerializeField] private GameObject _rightBushGroup;
    [SerializeField] private ParticleSystem _secondParticle;

    private bool _isParticleActive = true;

    private void OnMouseDown()
    {
        _rightBushGroup.SetActive(true);

        if (_isParticleActive)
        {
            _secondParticle.Stop();
            _isParticleActive = false;
        }
    }
}
