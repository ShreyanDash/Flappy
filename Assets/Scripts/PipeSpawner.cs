using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2.5f;
    public float spawnX = 8f;
    public float minY = -1f;
    public float maxY = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
