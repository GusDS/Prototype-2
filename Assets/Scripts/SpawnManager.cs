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
        InvokeRepeating("SpawnRandomInterval", startDelay, spawnMinInterval);
    }

/*    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
*/
    void SpawnRandomInterval()
    {
        randomInterval = Random.Range(0f, spawnMaxInterval - spawnMinInterval);
        Invoke("SpawnRandomAnimal", randomInterval);
    }

    void SpawnRandomAnimal()
    {
        // spawnInterval es ahora el mínimo
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spanwPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spanwPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
