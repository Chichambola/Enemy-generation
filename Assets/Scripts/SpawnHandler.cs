using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;


public class SpawnHandler : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;
    [SerializeField] private List<Target> _targets;

    private Coroutine _coroutine;
    private int _spawnRate = 2;

    private void Awake()
    {
        _coroutine = StartCoroutine(WaitForSpawn());
    }

    private IEnumerator WaitForSpawn()
    {
        var wait = new WaitForSecondsRealtime(_spawnRate);

        while (enabled) 
        {
            yield return wait;

            InitiateSpawn();
        }
    }

    private void InitiateSpawn()
    {
        int firstIndex = 0;

        int randomSpawner = Random.Range(firstIndex, _spawners.Count);
        int randomTarget = Random.Range(firstIndex, _targets.Count);

        _spawners[randomSpawner].Spawn(_targets[randomTarget]);
    }
}
