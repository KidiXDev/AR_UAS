using UnityEngine;

public class PoliceLight : MonoBehaviour
{
    public Light redLight;
    public Light blueLight;
    public float onIntensity = 5f;
    public float lightSwitchInterval = 0.5f;

    private float timer = 0f;
    private bool isRedOn = true; // flag buat ganti-gantian

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lightSwitchInterval)
        {
            // Ganti status lampu
            isRedOn = !isRedOn;

            if (redLight != null)
                redLight.intensity = isRedOn ? onIntensity : 0f;

            if (blueLight != null)
                blueLight.intensity = isRedOn ? 0f : onIntensity;

            timer = 0f;
        }
    }
}
