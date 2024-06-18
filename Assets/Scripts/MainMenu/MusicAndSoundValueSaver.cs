using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAndSoundValueSaver : MonoBehaviour
{
    [SerializeField] private AudioSource _musicPlayer; 
    [SerializeField] private AudioSource _soundPlayer;

    public static float MusicVolume;
    public static float SoundVolume;

    [SerializeField] private bool _isItMenu;

    private void Start()
    {
        if (_isItMenu)
        {
            MusicVolume = _musicPlayer.volume;
            SoundVolume = _soundPlayer.volume;
        }
        else
        {
            _musicPlayer.volume = MusicVolume;
            _soundPlayer.volume = SoundVolume;
        }
    }

    private void Update()
    {
        MusicVolume = _musicPlayer.volume;
        SoundVolume = _soundPlayer.volume;
    }
}
