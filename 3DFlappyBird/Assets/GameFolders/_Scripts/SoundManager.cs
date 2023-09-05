using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    private AudioSource audioSource;
    [SerializeField] List<AudioClip> soundEffects;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayOneShot(int index)
    {
        audioSource.PlayOneShot(soundEffects[index]);
    }
}
