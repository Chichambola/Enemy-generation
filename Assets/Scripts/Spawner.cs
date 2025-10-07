using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Character _character;

    public void Spawn()
    {
        var direction = Random.insideUnitSphere;

        Character newChar = Instantiate(_character, transform.position, Quaternion.identity);

        newChar.GetDirection(direction);
    }
}
