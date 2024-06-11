using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideoBoiler : MonoBehaviour
{
    public static Action<int> onVideoPlayed;

    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private RawImage _rawImage;

    [SerializeField] private VideoClip _firstVideo;
    [SerializeField] private VideoClip _secondVideo;
    [SerializeField] private VideoClip _thirdVideo;
    [SerializeField] private VideoClip _fourthVideo;
    [SerializeField] private VideoClip _fifthVideo;

    private void OnEnable()
    {
        onVideoPlayed += VideoClipChanger;
    }

    private void OnDisable()
    {
        onVideoPlayed -= VideoClipChanger;
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
        StopVideo();
    }

    private void StopVideo()
    {
        _rawImage.gameObject.SetActive(false);
    }

}
