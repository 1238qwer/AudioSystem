using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicPlayer : MonoBehaviour {

    private AudioSource audioSource;

    void Awake () {
        audioSource = GetComponent<AudioSource>();
	}

    public void SetMusic(AudioClip clip, bool isLoop, float volume)
    {
        audioSource.clip = clip;
        audioSource.loop = isLoop;
        audioSource.volume = volume;

        audioSource.Play(0);
    }

    public void SetMusicVolume(float volume)
    {
        audioSource.volume = volume;
    }




}
