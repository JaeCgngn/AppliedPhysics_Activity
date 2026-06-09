using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 checkpointPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkpointPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            Respawn();
        }
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        checkpointPosition = newCheckpoint;
    }

    void Respawn()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = checkpointPosition;
    }
}
