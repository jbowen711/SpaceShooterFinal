using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    [SerializeField] float spawnRate = 2f;
    [SerializeField] GameObject enemy2Prefab;

    float xMin;
    float xMax;
    float ySpawn;
    // Start is called before the first frame update
    void Start()
    {
    xMin = Camera.main.ViewportToWorldPoint(new Vector3(.1f, 0, 0)).x;
    xMax = Camera.main.ViewportToWorldPoint(new Vector3(.9f, 0, 0)).x;
    ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;

    InvokeRepeating("SpawnEnemy", 2f, spawnRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randX = Random.Range(xMin, xMax);
        Instantiate(enemy2Prefab, new Vector3(randX, ySpawn, 0), Quaternion.identity);


    }
}
