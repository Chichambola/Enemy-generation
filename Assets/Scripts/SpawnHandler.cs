using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;


public class SpawnHandler : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;

    private bool _isSpawning = true;
    private int _spawnRate = 2;

    private void Awake()
    {
        StartCoroutine(SpawnTime());
    }

    private IEnumerator SpawnTime()
    {
        while (_isSpawning) 
        {
            ChooseSpawner();

            yield return new WaitForSecondsRealtime(_spawnRate);
        }
    }

    private void ChooseSpawner()
    {
        int firstIndex = 0;

        int randomSpawner = Random.Range(firstIndex, _spawners.Count);

        _spawners[randomSpawner].Work();
    }
}
