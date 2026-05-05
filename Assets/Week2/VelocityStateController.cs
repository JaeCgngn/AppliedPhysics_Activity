using UnityEngine;

public class VelocityStateController : MonoBehaviour
{
    public enum MovementState { Idle, Walk, Run}

    public MovementState currentState;

    [Header("Speeds")]
    public float walkSpeed = 2f;
    public float runSpeed = 6f;

    private float currentVelocity;

    void Update()
    {
        HandleInput();
        ApplyVelocity();
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentState = MovementState.Run;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            currentState = MovementState.Walk;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentState = MovementState.Idle;
        }
    }

    void ApplyVelocity()
    {
        switch (currentState)
        {
            case MovementState.Idle:
                currentVelocity = 0f;
                break;

            case MovementState.Walk:
                currentVelocity = walkSpeed;
                break;

            case MovementState.Run:
                currentVelocity = runSpeed;
                break;
        }
        transform.position += Vector3.right * currentVelocity * Time.deltaTime;
    }
}
