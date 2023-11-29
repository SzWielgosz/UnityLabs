using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    public static TimeCounter Instance;
    private float currentTime = 0f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        timeIsRunning = true;
    }
    void Update()
    {
        if (timeIsRunning)
        {
            currentTime += Time.deltaTime;
            float minutes = Mathf.Floor(currentTime / 60);
            float seconds = Mathf.Floor(currentTime % 60);
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}

