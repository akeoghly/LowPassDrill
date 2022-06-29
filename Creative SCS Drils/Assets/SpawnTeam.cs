using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTeam : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 TeamSpawnPos;
    private Vector3 OppSpawnPos;

    public GameObject Teammate;

    public GameObject Opposition;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        TeamSpawnPos = new Vector3 (Random.Range(-13.5f, 13.5f), 0.5f, Ball.transform.position.z + 40f);
        OppSpawnPos = new Vector3(0f, 0.5f, Ball.transform.position.z + 20f);

        Instantiate(Teammate, TeamSpawnPos, transform.rotation);
        Instantiate(Opposition, OppSpawnPos, transform.rotation);
    }

}
