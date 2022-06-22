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

    // The code calculates the length of the path not yet traveled by the enemy
    // I've replaced Waypoints[curWaypointIndex + 1] on Waypoints[curWaypointIndex]
    public float DistanceToGoal()
    {
        float distance = 0;
        distance += Vector2.Distance(gameObject.transform.position, Waypoints[curWaypointIndex].transform.position);
        for (int i = curWaypointIndex; i < Waypoints.Length - 1; i++)
        {
            Vector3 startPosition = Waypoints[i].transform.position;
            Vector3 endPosition = Waypoints[i + 1].transform.position;
            distance += Vector2.Distance(startPosition, endPosition);
        }
        return distance;
    }
}
