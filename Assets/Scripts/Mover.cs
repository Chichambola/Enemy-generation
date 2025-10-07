using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public void MoveObject(GameObject gameObject)
    {
        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime);
    }
}
