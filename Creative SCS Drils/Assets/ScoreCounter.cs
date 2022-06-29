using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text ScoreCount;
    public int Score = 0;

    public Text FinalScore;

    public Text AttributePoints;
    public float AttPoints = 0f;

    public GameObject EndScreen;

    // Update is called once per frame
    void Start()
    {
        ScoreCount.text = "Score: " + Score;
    }

    void Update()
    {
        AttPoints = Mathf.Ceil(Score / 2);
        //if (Score == 10)
        //{
        //    Time.timeScale = 0;

        //    FinalScore.text = "Score: " + Score;
        //    AttributePoints.text = "You have earned " + AttPoints + " Attribute Points";
            
        //    EndScreen.SetActive(true);
            
        //}
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Team")
        {
            
            Score = Score + 1;
            ScoreCount.text = "Score: " + Score;
            FinalScore.text = "Score: " + Score;

            //AttributePoints.text = "You have earned " + Score / 2 + " Attribute Points";
        }
        if (col.gameObject.tag == "Opposition" || col.gameObject.tag == "Wall")
        {
            Time.timeScale = 0;
            FinalScore.text = "Score: " + Score;

            //AttributePoints.text = "You have earned " + AttPoints + " Attribute Points";
            EndScreen.SetActive(true);
        }
    }
}
