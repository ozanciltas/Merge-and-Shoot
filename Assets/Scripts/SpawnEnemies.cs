using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform spawnPoint;

    float timer = 10f;
    float timerDelta;
    void Update()
    {
        timerDelta -= Time.deltaTime;
        if (timerDelta <=0)
        {
            Spawn();
            timerDelta = timer;
        }
    }
    void Spawn()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
