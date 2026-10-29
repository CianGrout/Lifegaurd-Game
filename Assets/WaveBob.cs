using UnityEngine;

public class WaveBob : MonoBehaviour
{
        public float waveHeight = 0.2f;
    public float waveSpeed = 2.0f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * waveSpeed) * waveHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}