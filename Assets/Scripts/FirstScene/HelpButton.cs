using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    public void TapOnHelp()
    {
        _particleSystem.gameObject.SetActive(true);
        _particleSystem.Play();
        Invoke(nameof(StopParticle), 2f);
    }

    private void StopParticle()
    {
        _particleSystem.gameObject.SetActive(false);
    }
}
