using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, movementSpeed * Time.deltaTime);

        transform.LookAt(player);
    }
}
