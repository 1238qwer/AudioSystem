using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    [SerializeField] AudioManager audioManager;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioManager.SoundPlay(audioSource, "test");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioManager.MusicPlay("main");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            audioManager.MusicPlay("main2");
        }
    }
}
