using UnityEngine;

public class AccelerationController : MonoBehaviour
{
    [Header("Motion")]
    public float maxSpeed = 8f;
    public float acceleration = 10f;
    public float deceleration = 15f;

    public float velocity = 0f;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        if(Mathf.Abs (input) > 0.01f)
        {
            velocity += input * acceleration * Time.deltaTime;


        }
        else
        {
            velocity = Mathf.MoveTowards(velocity, 0, deceleration * Time.deltaTime);

        }

        velocity = Mathf.Clamp(velocity, -maxSpeed, maxSpeed);
        transform.position += Vector3.right * velocity * Time.deltaTime;

    }
}
