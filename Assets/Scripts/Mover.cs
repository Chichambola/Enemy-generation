using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private int _moveSpeed = 5;
    
    public void MoveObject(Target target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * _moveSpeed);
    }
}
