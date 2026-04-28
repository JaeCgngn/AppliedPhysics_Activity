using UnityEngine;

public class GravityBasedFalling : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(Vector3.down * 9.81f,ForceMode.Acceleration);
    }
}
