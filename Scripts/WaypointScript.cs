using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour {
    public bool loop;
    public bool reverse;
    public Transform[] waypoints;
    public float[] waitTime;
    public float speed;
    public Transform target;

    bool forward;
    Vector3 nextPoint;
    int index;
    float moveTime;
	// Use this for initialization
	void Start () {
        moveTime = 0.0f;
        forward = true;
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>=moveTime)
            MoveTarget();
    }

    void MoveTarget()
    {
        target.position = Vector3.MoveTowards(target.position, waypoints[index].position, speed * Time.deltaTime);
        if(Vector3.Distance(waypoints[index].position, target.position) <= 0)
        {
            moveTime = Time.time + waitTime[index];
            UpdateIndex();
        }
    }

    void UpdateIndex()
    {
        if(forward)
        {
            if (index == waypoints.Length-1)
            {
                if (loop)
                    index = 0;
                else if (reverse)
                {
                    index = index - 1;
                    forward = false;
                }
            }
            else
                index = index + 1;
        }
        else
        {
            if (index == 0)
            {
                index = index + 1;
                forward = true;
            }
            else
                index = index - 1;
        }
    }
}
