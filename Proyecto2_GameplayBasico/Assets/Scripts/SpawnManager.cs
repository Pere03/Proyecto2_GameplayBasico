using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject animalPrefab;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);
    private float xRange = 15f; 

    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }

    public Vector3 RandomSpawnPosition()
    {
        float RandomX = Random.Range(-xRange, xRange);
        return new Vector3(RandomX, 0, 25);
    }

    public void SpawnAnimal() 
    {
        spawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefab, spawnPosition,
        animalPrefab.transform.rotation);
    }
}
