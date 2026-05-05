using UnityEngine;
using TMPro;
public class DisplacementTracker : MonoBehaviour
{
    private float startX;
    private float timeElapsed;

    private Displacement displacement1;

    [SerializeField] private TMP_Text displacementText;

    void Start()
    {
        startX = transform.position.x;
        displacement1 = GetComponent<Displacement>();
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        float displacement = transform.position.x - startX;
        displacementText.text = $"Displacement: {displacement:F2} units\nTime Elapsed: {timeElapsed:F2} seconds \n Elapsed: {displacement1.elapsed}";
    }
}
