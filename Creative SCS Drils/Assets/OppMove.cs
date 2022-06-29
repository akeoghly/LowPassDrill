using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppMove : MonoBehaviour
{
    public GameObject RightPos;
    public GameObject LeftPos;

    public GameObject Ball;
    private ScoreCounter _scoreCounter;

    private Vector3 pos1;
    private Vector3 pos2;
    public float speed;

    public bool ChangeSpeed = true;

    //private int _playerScore;



    void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
        _scoreCounter = Ball.GetComponent<ScoreCounter>();

        pos1 = RightPos.transform.position;
        pos2 = LeftPos.transform.position;
        speed = Random.Range(0.2f, 0.4f);

        //_playerScore = _scoreCounter.Score;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        SpeedChange();
    }

    public void SpeedChange()
    {
        if (_scoreCounter.Score >= 1 && _scoreCounter.Score < 3 && ChangeSpeed == true)
        {
            speed = Random.Range(0.3f, 0.6f);
            ChangeSpeed = false;
        }

        else if (_scoreCounter.Score >= 3 && _scoreCounter.Score < 5 && ChangeSpeed == true)
        {
            speed = Random.Range(0.5f, 0.9f);
            ChangeSpeed = false;
        }

        else if (_scoreCounter.Score >= 5 && _scoreCounter.Score < 8 && ChangeSpeed == true)
        {
            speed = Random.Range(0.7f, 1.1f);
            ChangeSpeed = false;
        }

        else if (_scoreCounter.Score >= 8 && _scoreCounter.Score < 11 && ChangeSpeed == true)
        {
            speed = Random.Range(0.9f, 1.3f);
            ChangeSpeed = false;
        }

        else if (_scoreCounter.Score >= 11 && ChangeSpeed == true)
        {
            speed = Random.Range(1.2f, 1.8f);
            ChangeSpeed = false;
        }


    }


}
