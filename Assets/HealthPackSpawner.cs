using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    [Tooltip("The health pack prefab to spawn")]
    [SerializeField] private GameObject healthPackPrefab;

    [Tooltip("The time in seconds between health pack spawns")]
    [SerializeField] private float spawnInterval = 10f;

    private float timeSinceLastSpawn;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnHealthPack();
            timeSinceLastSpawn = 0;
        }
    }

    private void SpawnHealthPack()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-9, 9), 4, 0); // Adjust position
        Instantiate(healthPackPrefab, spawnPosition, Quaternion.identity);
    }
}
