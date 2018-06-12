using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Note this line, if it is left out, the script won't know that the class 'Path' exists and it will throw compiler errors
// This line should always be present at the top of scripts which use pathfinding
using Pathfinding;
using System;

public class AstarAI : MonoBehaviour
{
    public Transform targetPosition;

    private Seeker seeker;
    private CharacterController controller;

    public Path path;

    public float speed = 2;

    public float nextWaypointDistance = 3;

    private int currentWaypoint = 0;

    public float repathRate = 0.5f;
    private float lastRepath = float.NegativeInfinity;

    public bool reachedEndOfPath;

    private bool pathStart = false;

    public void Start()
    {
        seeker = GetComponent<Seeker>();
        
    }

    public void OnPathComplete(Path p)
    {
        
        
        p.Claim(this);
        if (!p.error)
        {
            if (path != null) path.Release(this);
            path = p;
            
            currentWaypoint = 0;
        }
        else
        {
            pathStart = false;
            p.Release(this);
        }
    }

    public void Update()
    {
        try
        {
            if (gameObject == GameManager.GameController.ActiveDeveloper.gameObject || pathStart )
            {
                ActivePath();
            }
        }
        catch (NullReferenceException e)
        {
            
        }
        
    }

    public void ActivePath()
    {
        pathStart = true;
        if (Time.time > lastRepath + repathRate && seeker.IsDone())
        {
            lastRepath = Time.time;
            seeker.StartPath(transform.position, targetPosition.position, OnPathComplete);
        }

        if (path == null)
        {

            return;
        }

        reachedEndOfPath = false;

        float distanceToWaypoint;
        while (true)
        {

            distanceToWaypoint = Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]);
            if (distanceToWaypoint < nextWaypointDistance)
            {

                if (currentWaypoint + 1 < path.vectorPath.Count)
                {
                    currentWaypoint++;
                }
                else
                {

                    reachedEndOfPath = true;
                    break;
                }
            }
            else
            {
                break;
            }
        }

        var speedFactor = reachedEndOfPath ? Mathf.Sqrt(distanceToWaypoint / nextWaypointDistance) : 1f;

        // Direction to the next waypoint
        // Normalize it so that it has a length of 1 world unit
        Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
        // Multiply the direction by our desired speed to get a velocity
        Vector3 velocity = dir * speed * speedFactor;
        transform.position += velocity * Time.deltaTime;
    }
}
