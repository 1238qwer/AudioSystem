using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class AudioManager : ScriptableObject {

    [SerializeField] private List<Audio> audioList = new List<Audio>();

    private AudioSource musicPlayer;

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
                    InitMusicPlayer();

                musicPlayer.clip = audio.clip;
                musicPlayer.loop = true;
                musicPlayer.volume = musicVolume;

                musicPlayer.Play(0);

            }
        }
    }

    private void InitMusicPlayer()
    {
        GameObject tmp = new GameObject("MusicPlayer");

        tmp.AddComponent<AudioSource>();
        musicPlayer = tmp.GetComponent<AudioSource>();
        DontDestroyOnLoad(musicPlayer);
    }

    public void SoundVolumeChanged(float volume)
    {
        soundVolume = volume;
    }

    public void MusicVolumeChanged(float volume)
    {
        if (musicPlayer == null)
            InitMusicPlayer();

        musicVolume = volume;
        musicPlayer.volume = volume;
    }


}
