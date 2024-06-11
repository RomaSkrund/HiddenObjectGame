using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PoisonVideoPlayer : MonoBehaviour
{
    public static Action<int> onVideoPlayed;

    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private RawImage _rawImage;

    [SerializeField] private VideoClip _firstVideo;
    [SerializeField] private VideoClip _secondVideo;
    [SerializeField] private VideoClip _thirdVideo;
    [SerializeField] private VideoClip _fourthVideo;
    [SerializeField] private VideoClip _fifthVideo;
    [SerializeField] private VideoClip _sixthVideo;
    [SerializeField] private VideoClip _seventhVideo;

    private void OnEnable()
    {
        onVideoPlayed += VideoClipChanger;
        TapOnPoison.onPoisonGeted += StopVideo;
    }

    private void OnDisable()
    {
        onVideoPlayed -= VideoClipChanger;
        TapOnPoison.onPoisonGeted -= StopVideo;
    }

    private void VideoClipChanger(int numberOfClip)
    {
        switch (numberOfClip)
        {
            case 1:
                _videoPlayer.clip = _firstVideo;
                PlayVideo();
                break;
            case 2:
                _videoPlayer.clip = _secondVideo;
                PlayVideo();
                break;
            case 3:
                _videoPlayer.clip = _thirdVideo;
                PlayVideo();
                break;
            case 4:
                _videoPlayer.clip = _fourthVideo;
                PlayVideo();
                break;
            case 5:
                _videoPlayer.clip = _fifthVideo;
                PlayVideo();
                break;
            case 6:
                _videoPlayer.clip = _sixthVideo;
                PlayVideo();
                break;
            case 7:
                _videoPlayer.clip = _seventhVideo;
                PlayVideo();
                break;
        }
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
    }

    private void StopVideo()
    {
        _videoPlayer.enabled = false;
        _rawImage.gameObject.SetActive(false);
    }

}
