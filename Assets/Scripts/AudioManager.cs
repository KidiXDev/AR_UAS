using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Audio Sources")]
    private AudioSource musicSource;
    private AudioSource sfxSource;

    [Header("Audio Settings")]
    [Range(0f, 1f)]
    public float musicVolume = 0.7f;
    [Range(0f, 1f)]
    public float sfxVolume = 1f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeAudioSources();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void InitializeAudioSources()
    {
        // Create dedicated music AudioSource
        GameObject musicObject = new GameObject("MusicSource");
        musicObject.transform.SetParent(transform);
        musicSource = musicObject.AddComponent<AudioSource>();
        musicSource.loop = true;
        musicSource.playOnAwake = false;
        musicSource.priority = 64;

        // Create dedicated SFX AudioSource
        GameObject sfxObject = new GameObject("SFXSource");
        sfxObject.transform.SetParent(transform);
        sfxSource = sfxObject.AddComponent<AudioSource>();
        sfxSource.playOnAwake = false;
        sfxSource.priority = 128;

        UpdateVolume();
    }

    public void PlayMusic(AudioClip clip)
    {
        if (musicSource && clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if (sfxSource && clip)
        {
            sfxSource.PlayOneShot(clip);
        }
    }

    public void StopMusic()
    {
        if (musicSource)
            musicSource.Stop();
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = Mathf.Clamp01(volume);
        if (musicSource)
            musicSource.volume = musicVolume;
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = Mathf.Clamp01(volume);
        if (sfxSource)
            sfxSource.volume = sfxVolume;
    }

    void UpdateVolume()
    {
        if (musicSource)
            musicSource.volume = musicVolume;
        if (sfxSource)
            sfxSource.volume = sfxVolume;
    }
}
