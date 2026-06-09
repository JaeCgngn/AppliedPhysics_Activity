using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class WreckingBallSwing : MonoBehaviour
{

    private Rigidbody rb;
    private LineRenderer line;
    public float swingForce = 1f;
    public Transform anchor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        line = GetComponent<LineRenderer>();
        //line.positionCount = 2;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(rb.linearVelocity.normalized * swingForce);
        
    }

    void Update()
    {
        if (anchor != null)
        {
            line.SetPosition(0, anchor.position);
            line.SetPosition(1, transform.position);
        }
    }
}
