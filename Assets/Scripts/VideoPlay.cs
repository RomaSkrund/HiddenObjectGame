using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private RawImage _rawImage;

    private void Start()
    {
        _rawImage.gameObject.SetActive(true);
        _videoPlayer.Play();
        StartCoroutine(StartVideo());
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _videoPlayer.enabled = false;
            _rawImage.gameObject.SetActive(false);
        }
    }

    IEnumerator StartVideo()
    {
        yield return new WaitForSeconds((float)_videoPlayer.length);
        _videoPlayer.enabled = false;
        _rawImage.gameObject.SetActive(false);
    }
}
