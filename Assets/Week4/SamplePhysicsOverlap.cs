using UnityEngine;

public class SamplePhysicsOverlap : MonoBehaviour
{

    public float radius = 5f;
    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Enemy"))
            {
                Debug.Log("Damaged Enemy: " + hit.name);
                MeshRenderer mesh = hit.GetComponent<MeshRenderer>();
                mesh.material.color = Color.blueViolet;

                float dis = Vector3.Distance(hit.transform.position, player.transform.position);
                Debug.Log($"Distance of Enemy {hit.name} to {player.name} is {dis}");
            }
            
        }
        //Destroy(gameObject, 0.1f);
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
