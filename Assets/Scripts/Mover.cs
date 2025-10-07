using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public void MoveObject(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
