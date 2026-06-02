using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SpringTest : MonoBehaviour
{
    [SerializeField] Transform anchor;
    private Rigidbody rb;
    private LineRenderer line;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody>();
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, anchor.position);
        line.SetPosition(1, transform.position);
    }
}
