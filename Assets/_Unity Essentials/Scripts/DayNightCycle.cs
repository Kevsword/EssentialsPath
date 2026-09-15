using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length")]
    [Tooltip("How many real-world seconds a full day takes.")]
    [SerializeField] private float dayDurationInSeconds = 300f;

    private float degreesPerSecond;

    private void Start()
    {
        degreesPerSecond = 360f / dayDurationInSeconds;
    }

    private void Update()
    {
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }

    private void OnValidate()
    {
        if (dayDurationInSeconds < 1f)
            dayDurationInSeconds = 1f;
    }
}