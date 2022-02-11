using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{

    public float timeRemaining = 0f;
    public bool timerIsRunning = false;
    public Text timeText;

    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            timeRemaining += Time.deltaTime;
            DisplayTime(timeRemaining);

        }
    }

    //  void DisplayTime(float timeToDisplay)
    //    {
    //      float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    //       float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    //       timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    //   }


    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
