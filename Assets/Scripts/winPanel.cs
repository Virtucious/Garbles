using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winPanel : MonoBehaviour
{
    static public winPanel Instance;


    public int switchCount;
    public GameObject panel;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
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
