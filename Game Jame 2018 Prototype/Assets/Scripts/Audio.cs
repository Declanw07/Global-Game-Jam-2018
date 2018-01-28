using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour {

    public Slider mVolume;
    public AudioSource mainMusic;
    
    public AudioClip[] Tracks;
    

    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
        mainMusic.volume = mVolume.value;

	}
}
