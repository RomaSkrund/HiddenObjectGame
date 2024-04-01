using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButtons : MonoBehaviour
{
    [SerializeField] private Slider _vloumeSlider;
    [SerializeField] private AudioSource _audioSource;

    public void PlusVolume()
    {
        _vloumeSlider.value += 0.1f;
    }

    public void MinusVolume()
    {
        _vloumeSlider.value -= 0.1f;
    }

    public void MusicVolumeChange(float sliderValue)
    {
        _audioSource.volume = sliderValue;
    }
}
