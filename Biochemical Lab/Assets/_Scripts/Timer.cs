using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    public Text startBtnText;

    bool timerActive = false; // whether or not the button is active

    void Start()
    {
        textBox.text = timeStart.ToString("f2");
    }


    void Update()
    {
        if(timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("f2");
        }
    }

    public void timerButton()
    {
        timerActive = !timerActive;
        startBtnText.text = timerActive ? "Pause" : "Start";
    }
}
