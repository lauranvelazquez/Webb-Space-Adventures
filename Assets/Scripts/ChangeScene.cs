using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayer;
    [SerializeField] private GameObject playButton; 

    private VideoPlayer _player;

    private void Start()
    {
        _player = videoPlayer.GetComponent<VideoPlayer>();
        playButton.GetComponent<Button>().onClick.AddListener(PlayVideo);
    }

    //Detect if a click occurs
    void PlayVideo()
    {
        //Show Video
        videoPlayer.SetActive(true);
        playButton.GameObject().SetActive(false);
    }

    void Update()
    {
        //Debug.Log("1 " + _player.frame + " 2 " + _player.frameCount);
        if ((ulong)_player.frame == _player.frameCount - 3)
        {
            //Debug.Log("Anda we");
            SceneManager.LoadScene("GameScene");  
        }
    }
}
