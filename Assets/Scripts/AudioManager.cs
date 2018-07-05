using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class AudioManager : ScriptableObject {

    [SerializeField] private List<Audio> audioList = new List<Audio>();
    [SerializeField] private Main main;

    private MusicPlayer musicPlayer;

    private float soundVolume;
    private float musicVolume;

    public interface audioSoureHandler
    {
       
    }
    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("soundVolume", soundVolume);
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
    }

    public void SoundPlay(AudioSource audioSource, string audioID)
    {
        foreach (Audio audio in audioList)
        {
            if (audio.ID == audioID)
            {
                audioSource.PlayOneShot(audio.clip,audioSource.volume * soundVolume);
            }
        }     

    }

    public void MusicPlay(string audioID)
    {
        foreach (Audio audio in audioList)
        {
            if (audio.ID == audioID)
            {
                if (musicPlayer == null)
                  musicPlayer = main.GetMusicPlayer();

                Debug.Log(musicPlayer)
;                musicPlayer.SetMusic(audio.clip, true, musicVolume);

            }
        }
    }

    public void SoundVolumeChanged(float volume)
    {
        soundVolume = volume;
    }

    public void MusicVolumeChanged(float volume)
    {
        if (musicPlayer == null)
            musicPlayer = main.GetMusicPlayer();

        musicVolume = volume;
        musicPlayer.SetMusicVolume(volume);
    }


}
