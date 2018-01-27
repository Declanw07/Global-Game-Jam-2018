using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {


    public Image heatBar;
    public HeatBehaviourScript heatScript;


    public Sprite heatBarSprite;

	// Use this for initialization
	void Start () {

        heatBarSprite = heatBar.GetComponent<Sprite>();
        heatScript = this.GetComponent<HeatBehaviourScript>();
		
	}
	
	// Update is called once per frame
	void Update () {

        heatScript.UpdateHeatUI();
		
	}

    public void updatePlayerHeat(float heatChange)
    {

        heatScript.HeatUpdate(heatChange);

    }

    /*public void UpdateHeatBarScale(float heatValPercent)
    {
        Image parentImage = this.GetComponentInParent<Image>();

        Debug.Log(heatValPercent);
        heatBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, parentImage.rectTransform.sizeDelta.x * heatValPercent);
        //heatBar.rectTransform.position = new Vector2(GetComponentInParent<>)
        //heatBarSprite.rect.width = Mathf.RoundToInt(600 * heatValPercent);

    }*/
}
