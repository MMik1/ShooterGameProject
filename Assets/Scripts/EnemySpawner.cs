using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float spawnInterval = 2.0f; // Adjust the interval as needed

    // Start is called before the first frame update
    void Start()
    {
        // Call the SpawnEnemy function with a delay and repeat at the specified interval
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    // Function to spawn an enemy
    void SpawnEnemy()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
