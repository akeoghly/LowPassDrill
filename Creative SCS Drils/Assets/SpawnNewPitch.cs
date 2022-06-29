using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewPitch : MonoBehaviour
{
    public GameObject Ball;

    public GameObject Pitch;
    private Vector3 _pitchPos;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Team")
        {
            _pitchPos = new Vector3(0f, 0f, Ball.transform.position.z + 5f);
            

            Instantiate(Pitch, _pitchPos, transform.rotation);
            


        }
    }
}
