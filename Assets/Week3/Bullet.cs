using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Animator anim =
                collision.gameObject.GetComponent<Animator>();

            if (anim != null)
            {
                anim.enabled = false;
            }

            EnemyMovement movement =
                collision.gameObject.GetComponent<EnemyMovement>();

            if (movement != null)
            {
                movement.enabled = false;
            }

            // Destroy bullet
            Destroy(gameObject);
        }
    }


}
