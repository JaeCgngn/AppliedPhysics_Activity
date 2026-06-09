using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float pushForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with obstacle!");
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

            if (playerRb != null)
            {
                Vector3 pushDirection = (collision.transform.position - transform.position).normalized;

                pushDirection.y = 0.5f;

                playerRb.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
            }
        }
    }
}
