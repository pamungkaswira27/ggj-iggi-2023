using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Background Musics")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip backgroundMusicClip;

    [Header("Sound Effects")]
    [SerializeField] AudioClip itemPickedUpClip;
    [SerializeField] AudioClip dialogueClip;
    [SerializeField] AudioClip acceptQuestClip;
    [SerializeField] AudioClip questCompleteClip;
    [SerializeField] AudioClip npcHelpedClip;
    [SerializeField] AudioClip takeWaterClip;
    [Range(0f, 1f)]
    [SerializeField] float soundEffectVolume;

    Camera cam;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        cam = Camera.main;
    }

    public void PlayBGM()
    {
        StartCoroutine(PlayBGMCoroutine(backgroundMusicClip));
    }

    public void PlayItemPickedUpSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    public void PlayDialogueSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    public void PlayAcceptQuestSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    public void PlayQuestCompleteSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    public void PlayNPCHelpedSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    public void PlayTakeWaterSFX()
    {
        PlayClip(itemPickedUpClip, soundEffectVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 camPosition = cam.transform.position;
            AudioSource.PlayClipAtPoint(clip, camPosition, volume);
        }
    }

    IEnumerator PlayBGMCoroutine(AudioClip clip)
    {
        yield return new WaitForSeconds(0.5f);

        if (clip != null)
        {
            audioSource.clip = clip;

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
