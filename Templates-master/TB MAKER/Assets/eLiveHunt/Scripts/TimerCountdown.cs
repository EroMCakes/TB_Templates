using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    [Header("Timertext")]
    [SerializeField] private Text TimerText;
    [SerializeField] private char characterSpliter = ':';

    [Header("Logic")]
    private float timer;
    private bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        StartTimer(3600);
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            timer -= Time.deltaTime;
            UpdateText();
        }
    }

    private void UpdateText()
    {
        float seconds = ((int)timer % 60);
        float minutes = ((int)(timer / 60) %  60);

        TimerText.text = minutes.ToString("00") + characterSpliter + seconds.ToString("00");
    }

    private void StartTimer(float minutes)
    {
        isActive = true;
        timer = minutes;
        UpdateText();
    }
}
