using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButton : MonoBehaviour
{
    public Button timerButonVisual;

    void Start()
    {
        Button timerButtonClick = timerButonVisual.GetComponent<Button>();
        timerButtonClick.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
