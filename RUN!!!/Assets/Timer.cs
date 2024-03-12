using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public Text timerText;
    public int remainingTime;
    public GameOverScreen gameOver;

    public void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while(remainingTime > 0)
        {
            timerText.text = remainingTime.ToString();

            yield return new WaitForSeconds(1f);

            remainingTime--;
        }

        timerText.text = "";
        gameOver.GameOver(1);

    }


}
