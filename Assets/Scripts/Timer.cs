using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float remainingTime = 20f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI time;


    private void Start()
    {
        timerIsRunning = true;
        time.text = remainingTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            time.text = ((int) remainingTime).ToString();
        }
        else
        {
            remainingTime = 0;
            timerIsRunning=false;

        }
    }
}
