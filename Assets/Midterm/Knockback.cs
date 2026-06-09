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
            Debug.Log("Player collided with knockback object!");
            
            if (rb != null)
            {
                Vector3 knockbackDirection = (transform.position - collision.transform.position).normalized;
                knockbackDirection.y = 0.1f;
                rb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
            }
        }
    }
}
