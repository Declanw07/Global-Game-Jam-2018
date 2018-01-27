using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBehaviourScript : MonoBehaviour {

    [Range(0, 100)]
    public float heatValue;         // Change this value in the inspector.

    public PlayerScript playerScript;
    public Color currentHeatColour;
    public Color lowestHeatColour;
    public Color highestHeatColour;

    

	// Use this for initialization
	void Start () {

        playerScript = this.GetComponent<PlayerScript>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // This function is public and called from the PlayerScript.cs each frame in update().
    public void HeatUpdate(float heatChange)
    {
        // Change the cucrrent heat value based on the value added or subtracted
        // heatChange should be negative to take away heat and positive to add heat.
        heatValue += heatChange;
        UpdateHeatUI();

    }

    public void UpdateHeatUI()
    {

        // This line is to find a percentage heat value to evaluate colour
        // colour is evaluated from blue to red using color.lerp
        float heatPercentage = heatValue / 100;

        currentHeatColour = Color.Lerp(lowestHeatColour, highestHeatColour, heatPercentage);
        playerScript.heatBar.color = currentHeatColour;

        //Debug.Log(heatPercentage);

        //playerScript.UpdateHeatBarScale(heatPercentage); // Taken out for now will fix tomorrow.


    }
}
