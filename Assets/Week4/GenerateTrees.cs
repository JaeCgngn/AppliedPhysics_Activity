using UnityEngine;

public class GenerateTrees : MonoBehaviour
{
    public GameObject treePrefab;
    public int treeCount = 15;
    public int treeSpacing = 5;
    public float areaSize = 10f;
    public float maxHeight = 5f;
    public float waterLevel = 0.4f;
    public LayerMask groundLayer;
    public LayerMask treeLayer;

    private void Start()
    {
        int spawnedTrees = 0;

        while (spawnedTrees < treeCount)
        {
            float randomX = Random.Range(0, areaSize);
            float randomY = Random.Range(0, areaSize);

            Vector3 rayOrigin = new Vector3(randomX, 10f, randomY);
            RaycastHit hit;

            if (Physics.Raycast (rayOrigin, Vector3.down, out hit, maxHeight * 2f, groundLayer))
            {
                if (hit.point.y <= waterLevel)
                {
                    continue;
                }

                Collider[] nearby = Physics.OverlapSphere(hit.point, treeSpacing, treeLayer);

                if (nearby.Length > 0) 
                {
                    continue;
                }

                GameObject tree = Instantiate(treePrefab, hit.point, Quaternion.Euler(0, Random.Range(0,360), 0));

                tree.layer = LayerMask.NameToLayer("Tree");

                spawnedTrees++;
            }
        }

    }
}
