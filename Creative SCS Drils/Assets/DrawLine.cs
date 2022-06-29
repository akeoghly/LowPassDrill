using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRend;
    public GameObject Ball;
    public GameObject MouseFollow;

    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
        lineRend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        lineRend.SetPosition(0, new Vector3(MouseFollow.transform.position.x, 0f, MouseFollow.transform.position.z));
        lineRend.SetPosition(1, new Vector3(Ball.transform.position.x, 0f, Ball.transform.position.z));
    }
}
