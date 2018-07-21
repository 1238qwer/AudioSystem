using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class AudioManager : ScriptableObject {

    [SerializeField] private List<AudioClip> audioList = new List<AudioClip>();
    private List<AudioSource> playingSources = new List<AudioSource>();

    private float masterVolume;

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("soundVolume", masterVolume);
    }

    public void SoundPlay(AudioSource audioSource, string audioID)
    {
        foreach (AudioClip audio in audioList)
        {
            if (audio.name == audioID)
            {              
                if (audio.length >= 30f)
                {
                    foreach (AudioSource item in playingSources)
                    {
                        item.Stop();
                    }
                    if (!playingSources.Contains(audioSource))
                    {
                        audioSource.loop = true;
                        playingSources.Add(audioSource);
                    }
                }
                audioSource.PlayOneShot(audio, audioSource.volume * masterVolume);
            }
        }     
    }

    public void SoundVolumeChanged(float volume)
    {
        masterVolume = volume;

        foreach (AudioSource item in playingSources)
        {
            item.volume = masterVolume;
        }
    }
}
