using UnityEngine;

public class AudioGameplay : MonoBehaviour
{
    [Header("Ambience Settings")]
    public AudioClip ambienceClip;
    public bool playOnStart = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playOnStart && ambienceClip != null)
        {
            PlayAmbienceSound();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAmbienceSound()
    {
        if (AudioManager.Instance != null && ambienceClip != null)
        {
            AudioManager.Instance.PlayMusic(ambienceClip);
        }
        else
        {
            Debug.LogWarning("AudioManager instance not found or ambience clip is null!");
        }
    }

    public void StopAmbienceSound()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.StopMusic();
        }
    }
}
