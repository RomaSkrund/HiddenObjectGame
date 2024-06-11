using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class FinalVideo : MonoBehaviour
{
    public static Action onFinalSceneStarted;

    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private RawImage _rawImage;
    [SerializeField] private VideoClip _finalVideo;

    private void OnEnable()
    {
        onFinalSceneStarted += FinalEvents;
    }

    private void OnDisable()
    {
        onFinalSceneStarted += FinalEvents;
    }

    private void FinalEvents()
    {
        _videoPlayer.clip = _finalVideo;
        PlayVideo();
    }


    private void PlayVideo()
    {
        _rawImage.gameObject.SetActive(true);
        _videoPlayer.Play();
        StartCoroutine(StartVideo());
    }

    IEnumerator StartVideo()
    {
        yield return new WaitForSeconds((float)_videoPlayer.length);
        SceneManager.LoadScene(0);
    }
}
