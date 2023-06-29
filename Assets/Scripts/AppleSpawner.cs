using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject objectPrefab;         // The prefab of the object to spawn
    public float spawnInterval = 5f;        // Time interval between spawns
    public float objectDuration = 10f;      // Duration before the object is destroyed
    private float timer = 3f;

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if it's time to spawn a new object
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f; // Reset the timer
        }
    }

    void SpawnObject()
    {
        // Instantiate the object prefab
        GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.Euler(90, 0, 0));

        // Destroy the object after a certain duration
        Destroy(newObject, objectDuration);
    }
}
