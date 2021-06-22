using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public static TimeController instance;
    public Text crono;
    private TimeSpan tiempoCrono;
    private bool timerBool;
    private float transcurredTime;
    
    void Start()
    {
        crono.text = "Time: 00:00:00";
        timerBool = false;
    }

    private void Awake()
    {
        instance = this;
    }

    public void StartTime()
    {
        timerBool = true;
        transcurredTime = 0f;

        StartCoroutine(ActUpdate());
    }

    public void EndTime() 
    {
        timerBool = false;
    }

    private IEnumerator ActUpdate()
    {
        while (timerBool)
        {
            transcurredTime += Time.deltaTime;
            tiempoCrono = TimeSpan.FromSeconds(transcurredTime);
            string tiempoCronoStr = "Time: " + tiempoCrono.ToString("mm':'ss'.'ff");
            crono.text = tiempoCronoStr;

            yield return null;
        }
    }
}
