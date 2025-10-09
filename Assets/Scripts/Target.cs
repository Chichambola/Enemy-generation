using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Random = UnityEngine.Random;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints;

    private float _speed = 3f;
    private Coroutine _coroutine;

    private void Awake()
    {
        _coroutine = StartCoroutine(Moving());
    }

    private IEnumerator Moving()
    {
        while (enabled)
        {
            Vector3 waypointPosition = GetWaypointPosition();
        
            while (transform.position != waypointPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypointPosition, Time.deltaTime * _speed);
            
                yield return null;
            }   
        }
    }

    private Vector3 GetWaypointPosition()
    {
        int firstIndex = 0;
        
        var waypoint = _waypoints[Random.Range(firstIndex, _waypoints.Count)];
        
        return waypoint.transform.position;
    }
}
