using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemySpawn;
    public float spawnInterval = 1f;
    public int enemyCount = 10;

    public Transform A1;
    public Transform A2;
    public Transform A3;

    private Transform[] spawnAreas;

    private void Start()
    {
        spawnAreas = new Transform[]
        { A1, A2, A3 };

        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);

    }

    

    void SpawnEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length >= enemyCount)
        {
            return;
        }

        Transform randomSpawn = spawnAreas[Random.Range(0, spawnAreas.Length)];

        Instantiate(enemySpawn, randomSpawn.position, Quaternion.identity);

    }
}
