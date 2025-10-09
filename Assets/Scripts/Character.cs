using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Character : MonoBehaviour
{
    private Mover _mover;

    private Target _target;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.MoveObject(_target);
    }

    public void GetTarget(Target target)
    {
        _target = target;
    }
}
