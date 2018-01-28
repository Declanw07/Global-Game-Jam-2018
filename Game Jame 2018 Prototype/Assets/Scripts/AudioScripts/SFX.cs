using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour {

    public Slider SFXVolume;
    public AudioSource SFXSource;

    public AudioClip[] Sounds;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        SFXSource.volume = SFXVolume.value;
    }
}
