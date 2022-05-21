using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public bool finished = false;
    private bool started = false;

    string seconds;
    string minutes;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void TimerStart()
    {
        startTime = Time.time;
        started = true;
        RunTimer();
    }
    public void RunTimer()
    {
        if(!finished)
        {
        float t = Time.time - startTime;
        minutes = ((int) t / 60).ToString();
        seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
        }
        else if (finished)
        {
            timerText.text = minutes + ":" + seconds;
        }

    }

    public void TimerStop()
    {
        finished = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            RunTimer();
        }
    }

        /*
    public void StartTimer()
    {
        if (Input.GetKey("f"))
        {
            started = true;
            startTime = Time.time;
        }
    }
    */
}
