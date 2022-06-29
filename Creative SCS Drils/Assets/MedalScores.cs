using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalScores : MonoBehaviour
{
    public int Bronze = 3;
    public int Silver = 8;
    public int Gold = 12;

    public GameObject Ball;
    private ScoreCounter _scoreCounter;

    void Start()
    {
        _scoreCounter = Ball.GetComponent<ScoreCounter>();
    }

    void Update()
    {
        if (_scoreCounter.Score < Bronze)
        {
            if ((Bronze - _scoreCounter.Score) == 1)
            {
                _scoreCounter.AttributePoints.text = "You haven't earned a medal this time. You need " + (Bronze - _scoreCounter.Score) + " more point for a Bronze medal";
            }
            else
            {
                _scoreCounter.AttributePoints.text = "You haven't earned a medal this time. You need " + (Bronze - _scoreCounter.Score) + " more points for a Bronze medal";
            }
            
        }

        else if (_scoreCounter.Score >= Bronze && _scoreCounter.Score < Silver)
        {
            _scoreCounter.AttributePoints.text = "Your score has earned you a Bronze medal. You need " + (Silver - _scoreCounter.Score) + " more points for a Silver medal";
        }

        else if (_scoreCounter.Score >= Silver && _scoreCounter.Score < Gold)
        {
            _scoreCounter.AttributePoints.text = "Your score has earned you a Silver medal. You need " + (Gold - _scoreCounter.Score) + " more points for a Gold medal";
        }

        else if (_scoreCounter.Score >= Gold)
        {
            _scoreCounter.AttributePoints.text = "Your score has earned you a Gold medal. Congratulations!";
        }
    }
}
