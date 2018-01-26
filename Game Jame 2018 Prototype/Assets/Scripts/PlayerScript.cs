using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    [Range(0, 100)]
    public short heatValue;

    public Image heatBar;


    private Sprite heatBarSprite;

	// Use this for initialization
	void Start () {

        heatBarSprite = heatBar.GetComponent<Sprite>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
