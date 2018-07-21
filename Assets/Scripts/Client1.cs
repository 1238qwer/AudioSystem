using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client1 : MonoBehaviour {

    [SerializeField] AudioManager audioManager;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioManager.SoundPlay(audioSource, "Laser");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            audioManager.SoundPlay(audioSource, "sans");
        }
    }
}
