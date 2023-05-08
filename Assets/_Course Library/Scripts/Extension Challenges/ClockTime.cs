using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    int seconds, minutes, hours;
    int oldSeconds, oldMinutes, oldHours;
    [SerializeField] private GameObject secondHand, minuteHand, hourHand, clockCenter;
    // Start is called before the first frame update
    void Start()
    {
        seconds = DateTime.Now.Second;
        minutes = DateTime.Now.Minute;
        hours = DateTime.Now.Hour;

        SetClock();
    }

    // Update is called once per frame
    void Update()
    {
        oldSeconds = seconds;
        oldMinutes = minutes;
        oldHours = hours;

        seconds = DateTime.Now.Second;
        minutes = DateTime.Now.Minute;
        hours = DateTime.Now.Hour;

        if(oldSeconds != seconds)
        {
            RotateSecond();
        }
        if (oldMinutes != minutes)
        {
            RotateMinute();
        }
        if (oldHours != hours)
        {
            RotateHour();
        }
    }

    private void RotateSecond()
    {
        secondHand.transform.RotateAround(clockCenter.transform.position, Vector3.forward, 6);
    }

    private void RotateMinute()
    {
        minuteHand.transform.RotateAround(clockCenter.transform.position, Vector3.forward, 6);
    }

    private void RotateHour()
    {
        hourHand.transform.RotateAround(clockCenter.transform.position, Vector3.forward, 30);
    }

    private void SetClock()
    {
        for (int i = 0; i < seconds; i++)
        {
            RotateSecond();
        }
        for (int i = 0; i < minutes; i++)
        {
            RotateMinute();
        }
        for (int i = 0; i < hours; i++)
        {
            RotateHour();
        }
    }
}
