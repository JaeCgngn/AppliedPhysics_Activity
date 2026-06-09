using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 5f;
    public float speed = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);

        transform.position = startPos + transform.right * movement;
    }
} 






