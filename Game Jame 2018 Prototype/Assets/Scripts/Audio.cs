using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour {

    public Slider mVolume;
    public AudioSource mainMusic;
    public AudioClip[] SFX;
    public AudioClip[] Music;
    public AudioClip[] News;
    public AudioClip[] VoiceLines;

    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        mainMusic.volume = mVolume.value;
	}
}
