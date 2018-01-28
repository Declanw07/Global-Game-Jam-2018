using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {

    public Slider dVolume;
    public AudioSource dialogSource;

    public AudioClip[] News;
    public AudioClip[] VoiceLines;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        dialogSource.volume = dVolume.value;

    }
}
