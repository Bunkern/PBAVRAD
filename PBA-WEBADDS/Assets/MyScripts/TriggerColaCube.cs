using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerColaCube : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject videoRender;
    public GameObject platform;
    public GameObject otherVideoPlayer;
    public GameObject otherVideoRender;
    public GameObject anotherVideoPlayer;
    public GameObject anotherVideoRender;


    public Text hudText;
    public Text addText;

    public int score;
    public int newScore;

    public GameManager gameManager;

    void OnTriggerEnter(Collider player)
    {        
        videoPlayer.SetActive(true);
        videoRender.SetActive(true);
        otherVideoPlayer.SetActive(false);
        otherVideoRender.SetActive(false);
        anotherVideoPlayer.SetActive(false);
        anotherVideoRender.SetActive(false);
        
    }

    void OnTriggerExit(Collider player)
    {
        gameManager.Score();
        platform.SetActive(false);
    }
}
