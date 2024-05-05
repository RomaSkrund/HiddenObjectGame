using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnBush : MonoBehaviour
{
    [SerializeField] private GameObject _searchItemsWindow;
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private GameObject _searchDuplet;

    private void OnMouseDown()
    {
        _searchItemsWindow.SetActive(true);
        _searchDuplet.SetActive(true);
        _particle.Stop();
        gameObject.SetActive(false);
    }
}
