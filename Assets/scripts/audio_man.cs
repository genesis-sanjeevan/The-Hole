using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_man : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sfx;

    public AudioClip background_music;
    public AudioClip womp;
    public AudioClip[] clips;

    private void Start()
    {
        music.clip = background_music;
        music.Play();
    }

    public void playsfx(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }

}
