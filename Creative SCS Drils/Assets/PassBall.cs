using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBall : MonoBehaviour
{
    public GameObject Ball;
    private float speed = 20f;

    public bool move;

    private MouseFollow _followMouse;

    void Start()
    {
        move = false;
        _followMouse = GetComponent<MouseFollow>();
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
        }

        if (move == false)
        {
            //Debug.Log("Stopped");
        }

        else if (move == true)
        {
            _followMouse.enabled = false;
            Ball.transform.position = Vector3.MoveTowards(Ball.transform.position, this.transform.position, speed * Time.deltaTime);
        }
            
    }
}
