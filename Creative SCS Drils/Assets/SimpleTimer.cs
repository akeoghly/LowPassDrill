using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SimpleTimer : MonoBehaviour
{

    public float targetTime = 60.0f;

    public Text TimerText;

    public GameObject EndScreen;

    void Update()
    {
        //var result = (Mathf.Round(targetTime * 100)) / 100.0;


        targetTime -= Time.deltaTime;

        TimerText.text = "Time Left: " + (Mathf.Round(targetTime * 100)) / 100.0;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        Time.timeScale = 0;
        EndScreen.SetActive(true);
    }


}