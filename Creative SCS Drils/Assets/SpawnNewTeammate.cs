using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewTeammate : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 TeamSpawnPos;
    private Vector3 OppSpawnPos;

    public GameObject Teammate;

    public GameObject Opposition;


    public GameObject FollowMouse;
    private PassBall _passBall;

    private MouseFollow _followMouse;

    public GameObject Pitch;
    private Vector3 _pitchPos;

    private ScoreCounter _scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        _passBall = FollowMouse.GetComponent<PassBall>();
        _followMouse = FollowMouse.GetComponent<MouseFollow>();
        _scoreCounter = Ball.GetComponent<ScoreCounter>();
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Team")
        {
            TeamSpawnPos = new Vector3(Random.Range(-13.5f, 13.5f), 0.5f, Ball.transform.position.z + 40f);
            OppSpawnPos = new Vector3(0f, 0.5f, Ball.transform.position.z + 20f);

            _pitchPos = new Vector3(0f, 0f, TeamSpawnPos.z - 43f);

            Instantiate(Teammate, TeamSpawnPos, transform.rotation);
            Instantiate(Opposition, OppSpawnPos, transform.rotation);

            if (_scoreCounter.Score >= 3)
            {
                OppSpawnPos = new Vector3(0f, 0.5f, Ball.transform.position.z + 10f);
                Instantiate(Opposition, OppSpawnPos, transform.rotation);
            }

            if (_scoreCounter.Score >= 7)
            {
                OppSpawnPos = new Vector3(0f, 0.5f, Ball.transform.position.z + 30f);
                Instantiate(Opposition, OppSpawnPos, transform.rotation);
            }


            Instantiate(Pitch, _pitchPos, transform.rotation);

            _passBall.move = false;
            _followMouse.enabled = true;
            
        }
    }
}
