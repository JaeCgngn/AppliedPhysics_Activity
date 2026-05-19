using UnityEngine;

public class GenerateTrees : MonoBehaviour
{
    public GameObject prefab;

    public int treeCount = 20;

    public float areaSize = 50f;

    public float checkRadius = 3f;

    public LayerMask treeLayer;

    private void Start()
    {
        Generate();
    }

    void Generate()
    {
        int spawnedTrees = 0;

        int attempts = 0;

        while (spawnedTrees < treeCount && attempts < 500)
        {
            attempts++;

            Vector3 randomPosition = GetRandomPosition();

            if (TryGetGroundPosition(randomPosition, out Vector3 hitPoint))
            {
                if (CanPlaceTree(hitPoint))
                {
                    SpawnTree(hitPoint);

                    spawnedTrees++;
                }
            }
        }
    }

    Vector3 GetRandomPosition()
    {
        float randomX =
            Random.Range(-areaSize, areaSize);

        float randomZ =
            Random.Range(-areaSize, areaSize);

        return new Vector3(randomX, 100f, randomZ);
    }

    bool TryGetGroundPosition(
        Vector3 rayOrigin,
        out Vector3 hitPoint
    )
    {
        RaycastHit hit;

        if (Physics.Raycast(
            rayOrigin,
            Vector3.down,
            out hit,
            200f))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                hitPoint = hit.point;

                return true;
            }
        }

        hitPoint = Vector3.zero;

        return false;
    }

    bool CanPlaceTree(Vector3 position)
    {
        Collider[] colliders =
            Physics.OverlapSphere(
                position,
                checkRadius,
                treeLayer
            );

        return colliders.Length == 0;
    }

    void SpawnTree(Vector3 position)
    {
        Instantiate(
            prefab,
            position,
            Quaternion.Euler(
                0,
                Random.Range(0, 360),
                0
            )
        );

        Debug.Log("Tree Spawned");
    }
}