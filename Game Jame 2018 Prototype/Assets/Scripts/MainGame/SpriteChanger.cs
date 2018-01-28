using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour {

    public GameObject cabinTran; //image child in pannel
    public Image nextCabin; //image on the child of the panel
    public Image image; //image on the panel
    public Sprite[] background; //array with all the backgrounds
    public Sprite cabinImage; //sprite applied to the panel
    public Sprite tranImage; //sprite applied ot the image child
    public float time; //time as float
    public int timer; //time as int
    public int currentImage = 0; //index for the current sprite
    public int nextImage = 1; // index for the next sprite
    public bool transmission = false; //bool to indicate a transmission has been triggered
    public bool transmitting = false; //bool to indicate the transmission is ongoing
    public Color tranAlpha;
    public Color cabinAlpha;
    public float t = 2f;
    static float lerpTime = 0.0f;

    // Use this for initialization
    void Start ()
    {
        //retrive the image child of the panel
        cabinTran = transform.Find("CabinTran").gameObject;
        nextCabin = cabinTran.GetComponent<Image>();
        tranImage = nextCabin.sprite;
        tranAlpha = nextCabin.color; //transmission alpha
        
        //retrives the image on the panel
        image = GetComponent<Image>();
        cabinImage = image.sprite;
        cabinAlpha = image.color; //cabin alpha
    }
	
	// Update is called once per frame
	void Update ()
    {
        //tranAlpha = Color.Lerp(Color.clear, Color.clear, Mathf.PingPong(Time.time, 1));
        

        nextCabin.color = tranAlpha;
        if (transmission != false && transmitting == false)
         {
            transmitting = true;

            if(currentImage > 2)
            {
                currentImage = 0;
            }
            if(nextImage > 2)
            {
                nextImage = 0;
            }
            Debug.Log("we here");
            while (tranAlpha.a < 255)
            {
                tranAlpha.a = Mathf.Lerp(0f, 255f, lerpTime);
                lerpTime += 0.5f * Time.deltaTime;
                nextCabin.color = tranAlpha;
                Debug.Log(tranAlpha.a);
            }
            
         }
	}
}
