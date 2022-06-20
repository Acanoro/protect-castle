using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCheckPoint : MonoBehaviour
{

    public float Speed;

    public Transform[] Waypoints;

    int curWaypointIndex = 0;

    // Update is called once per frame
    void Update()
    {

        if (curWaypointIndex < Waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, Waypoints[curWaypointIndex].position, Time.deltaTime * Speed);
            if (Vector3.Distance(transform.position, Waypoints[curWaypointIndex].position) < 0.5f)
            {
                curWaypointIndex++;
            }
        }

    }
}
