using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Character : MonoBehaviour
{
    private Mover _mover;

    private Vector3 _direction;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.MoveObject(_direction);
    }

    public void GetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
