using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class winPanel : MonoBehaviour
{
    static public winPanel Instance;
    public float remainingTime = 15f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI time;


    public int switchCount;
    public GameObject panel;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        timerIsRunning = true;
        time.text = remainingTime.ToString();
    }

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            time.text = ((int)remainingTime).ToString();
        }
        else
        {
            remainingTime = 0;
            timerIsRunning = false;

        }

        if (timerIsRunning == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (onCount == switchCount)
        {
            remainingTime = 1;
            Destroy(time);
        }
    }

    public void SwitchChange(int Points)
    {
        onCount = onCount + Points;
        if (onCount == switchCount)
        {
            panel.SetActive(true);
        }
    }
    
}
