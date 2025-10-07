using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public void MoveObject(GameObject gameObject)
    {
        while(true)
        {
            gameObject.transform.Translate(transform.forward);
        }
    }
}
