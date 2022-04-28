using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    int countDownStartValue = 15;
    public Text timerUI;

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            countDownTimer();
        }
    }

    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > -1)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "0" + spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }

        if (countDownStartValue < 9)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "00:0" + (spanTime.Seconds + 1.0f);
        }

        if (countDownStartValue == -1)
        {
            timerUI.text = "Game Over";
        }

        if (timerUI.text == "Game Over")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
