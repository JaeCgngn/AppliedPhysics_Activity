using UnityEngine;
using System.Collections;

public class OneDirectional : MonoBehaviour
{
    //EXAMPLE 1
    // Update is called once per frame
    //void Update()
    //{
    //    float x = Input.GetAxis("Horizontal");
    //    transform.position = new Vector3(0, 0.5f, 0); 
    //}

    public enum Axis { X, Y, Z }

    [Header("Motion Settings")]
    public Axis movementAxis = Axis.X;
    public float speed = 5f;


    private Vector3 direction;

    private void Update()
    {
        direction = GetAxisVector(movementAxis);
        transform.position += direction * speed * Time.deltaTime;
    }

    Vector3 GetAxisVector(Axis axis)
    {
        switch (axis)
        {
            case Axis.X:
                return Vector3.right;
            case Axis.Y:
                return Vector3.up;
            case Axis.Z:
                return Vector3.forward;
            default:
                return Vector3.right;
        }
    }
}
