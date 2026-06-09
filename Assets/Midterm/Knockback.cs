using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float knockbackForce = 10f;

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = collision.rigidbody;

            Vector3 knockbackDirection;

            if (enemyRb != null)
            {
                knockbackDirection = enemyRb.linearVelocity.normalized;
            }
            else
            {
                knockbackDirection = (transform.position - collision.transform.position).normalized;
            }

            knockbackDirection += Vector3.up * 0.2f;
            knockbackDirection.Normalize();

            rb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
        }
    }
}
