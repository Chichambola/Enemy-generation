using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;


public class SpawnHandler : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;

    private Coroutine _coroutine;
    private bool _isFirstIteration = true;
    private int _spawnRate = 2;

    private void Awake()
    {
        _coroutine = StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        var wait = new WaitForSecondsRealtime(_spawnRate);

        while (enabled) 
        {
            if (_isFirstIteration)
            {
                _isFirstIteration = false;

                yield return wait;
            }

            ChooseSpawner();

            yield return wait;
        }
    }

    private void ChooseSpawner()
    {
        int firstIndex = 0;

        int randomSpawner = Random.Range(firstIndex, _spawners.Count);

        _spawners[randomSpawner].Work();
    }
}
