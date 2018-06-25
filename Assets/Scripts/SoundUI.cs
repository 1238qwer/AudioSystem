using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUI : MonoBehaviour {

    [SerializeField] public Slider soundSlider;
    [SerializeField] public Slider musicSlider;

    [SerializeField] private AudioManager audioManager;

	void Start () {
        soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void SoundVolumeChanged()
    {
        audioManager.SoundVolumeChanged(soundSlider.value);
    }

    public void MusicVolumeChanged()
    {
        audioManager.MusicVolumeChanged(musicSlider.value);
    }
}
