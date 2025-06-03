using UnityEngine;

public class FloatAndRotate : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float floatAmplitude = 0.1f;
    public float floatFrequency = 1f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        // Rotasi terus
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Efek melayang naik turun (sinusoidal)
        float newY = startPos.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.localPosition = new Vector3(startPos.x, newY, startPos.z);
    }
}
