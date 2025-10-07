using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private Mover _mover;

    public void Work()
    {
        var newCube = Instantiate(_objectToSpawn);

        newCube.transform.position = gameObject.transform.position;

        _mover.MoveObject(newCube);
    }
}
