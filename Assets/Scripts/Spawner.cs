using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private Character _characterToSpawn;

    public void Work()
    {
        float minXValue = 0;
        float minZValue = 0;

        var newCube = Instantiate(_characterToSpawn.gameObject);

        newCube.transform.position = gameObject.transform.position;

        float newRotation = GetRotation();

        newCube.transform.Rotate(minXValue, newRotation, minZValue);
    }

    private float GetRotation()
    {
        float minYValue = 0;
        float maxYValue = 360;

        return Random.Range(minYValue, maxYValue);
    }
}
