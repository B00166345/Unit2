using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

public GameObject[] animalPrefrabs;
private readonly float spawnRangeX = 20;
private readonly float spawnPosZ = 20;
private readonly float startDelay = 2;
private readonly float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay,spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefrabs.Length);
            UnityEngine.Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            Instantiate(animalPrefrabs[animalIndex],spawnPos,animalPrefrabs[animalIndex].transform.rotation);
    }
}
