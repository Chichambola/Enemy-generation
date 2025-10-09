using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    private Coroutine _coroutine;

    private void Awake()
    {
        _coroutine = StartCoroutine(Moving());
    }

    private IEnumerator Moving()
    {
        float wait = 0.25f;

        while (enabled)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(GetRandomPosition().x, GetRandomPosition().y, GetRandomPosition().z), Time.deltaTime * wait);
            
            yield return new WaitForSecondsRealtime(wait);
        }
    }

    private Vector3 GetRandomPosition()
    {
        float minValue = 0;
        float maxValue = 100;

        return new Vector3(Random.Range(minValue, maxValue), 0, Random.Range(minValue, maxValue));
    }
}
