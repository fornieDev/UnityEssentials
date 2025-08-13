using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("Duration of a full day in seconds")]
    public float dayLengthInSeconds = 120f; // Default: 2 minutes for a full day

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed (360 degrees per day length in seconds)
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate day/night cycle
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
