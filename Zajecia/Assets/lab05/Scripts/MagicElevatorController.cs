using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicElevatorController : MonoBehaviour
{
    public List<Vector3> waypoints = new List<Vector3>();
    public float speed = 5f;
    private int waypointIndex = 0;
    void Update()
    {
        if (waypoints.Count == 0)
        {
            return;
        }
        MovePlatform();
    }

    void MovePlatform()
    {
        Vector3 direction = waypoints[waypointIndex] - transform.position;
        float distanceToWaypoint = direction.magnitude;

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (distanceToWaypoint < 0.1f)
        {
            waypointIndex = (waypointIndex + 1) % waypoints.Count;
        }
    }
}
