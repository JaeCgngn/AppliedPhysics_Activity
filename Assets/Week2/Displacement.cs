
using System.Collections;
using TMPro;
using UnityEngine;

public class Displacement : MonoBehaviour
{
    [SerializeField] private float dis;
    [SerializeField] private float duration;

    [HideInInspector] public float elapsed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Dash(dis, duration));
    }

    // Update is called once per frame
    IEnumerator Dash(float distance, float duration)
    {
        Vector3 start = transform.position;
        Vector3 end = start + Vector3.right * distance;
        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(start, end, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
    }
}
