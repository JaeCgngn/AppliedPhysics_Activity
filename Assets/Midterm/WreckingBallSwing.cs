using UnityEngine;

public class WreckingBallSwing : MonoBehaviour
{

    private Rigidbody rb;
    public float swingForce = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(rb.linearVelocity.normalized * swingForce);
        
    }
}
