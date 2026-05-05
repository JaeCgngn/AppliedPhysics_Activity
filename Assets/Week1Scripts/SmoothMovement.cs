using UnityEngine;
using UnityEngine.Rendering;

public class SmoothMovement : MonoBehaviour
{
    public float maxSpeed = 8f;
    public float acceleration = 20f;
    public float deceleration = 25f;

    float currentSpeed;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        
        if(Mathf.Abs(input) > 0.1f)
            currentSpeed = Mathf.MoveTowards(currentSpeed, maxSpeed * input, acceleration * Time.deltaTime);
        else
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);

        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
    }
}
