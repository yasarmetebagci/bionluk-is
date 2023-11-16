using UnityEngine;

public class DusmanSpawner : MonoBehaviour
{
    public GameObject dusmanPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnDusman", 0f, spawnInterval);
    }

    void SpawnDusman()
    {
        float randomY = Random.Range(-spawnRadius, spawnRadius);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

        Instantiate(dusmanPrefab, spawnPosition, Quaternion.identity);
    }
}
