using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUI : MonoBehaviour {

    [SerializeField] public Slider soundSlider;
    [SerializeField] private AudioManager audioManager;

	void Start () {
        soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }

    public void SoundVolumeChanged()
    {
        audioManager.SoundVolumeChanged(soundSlider.value);
    }
}
