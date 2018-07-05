using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Main : ScriptableObject {

    GameObject musicPlayerGameObject;

    public MusicPlayer GetMusicPlayer()
    {
        if (musicPlayerGameObject == null)
            CreateMusicPlayer();

        return musicPlayerGameObject.GetComponent<MusicPlayer>();
    }

    private void CreateMusicPlayer()
    {
        musicPlayerGameObject = new GameObject("MusicPlayer");

        musicPlayerGameObject.AddComponent<AudioSource>();
        musicPlayerGameObject.AddComponent<MusicPlayer>();

        DontDestroyOnLoad(musicPlayerGameObject);
    }


}
