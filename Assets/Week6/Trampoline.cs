using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] float trampolineForce = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.rigidbody)
        {
            return;
        }
        if(collision.contacts[0].normal.y >= 0.9f)
        {
            collision.rigidbody.AddForce(Vector3.up * trampolineForce, ForceMode.Impulse);
            Debug.Log("collision.gameObject.name");
    }
    }
}
