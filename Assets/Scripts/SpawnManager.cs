using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    private float startDelay = 3f;
    private float spawnMinInterval = 0.5f; // 2.2f;
    private float spawnMaxInterval = 3f;
    private float randomInterval;
    private int animalIndex;

    void Start() {
        // Initial delay 3 seconds count. MinInterval changed when added random interval range
        InvokeRepeating("SpawnRandomInterval", startDelay, spawnMinInterval);
    }

    void SpawnRandomInterval()
    {
        // Min 0.5 seconds since last spawn / Max 3 seconds between animals
        randomInterval = Random.Range(0f, spawnMaxInterval - spawnMinInterval);
        Invoke("SpawnRandomAnimal", randomInterval);
    }

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spanwPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spanwPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
