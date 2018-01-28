using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceManager : MonoBehaviour {

    // Array of cities.
    public InfluenceClass[] cities;

    // First element is happy, then second is okay then third is unhappy.
    public Sprite[] influenceSpriteTemplates;


	// Use this for initialization
	void Start () {
        // Find all cities within the scene.
        cities = GameObject.FindObjectsOfType<InfluenceClass>();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateCityElements();
	}

    public void UpdateCityElements()
    {
        foreach(InfluenceClass c in cities)
        {
            FavourCheck(c);
            InfluenceCheck(c);
            c.UpdateInfluenceBar();
        }

    }

    private void FavourCheck(InfluenceClass c)
    {
        if (c.favourValue >= 0 && c.favourValue < 34)
        {
            c.favourImage.sprite = influenceSpriteTemplates[2];
        }
        else if (c.favourValue >= 34 && c.favourValue < 67)
        {
            c.favourImage.sprite = influenceSpriteTemplates[1];
        }
        else if (c.favourValue >= 67 && c.favourValue < 101)
        {
            c.favourImage.sprite = influenceSpriteTemplates[0];
        }
    }

    private void InfluenceCheck(InfluenceClass c)
    {
        if (c.currentInfluence >= 0 && c.currentInfluence < 34)
        {
            c.influenceBar.color = Color.red;
        }
        else if (c.currentInfluence >= 34 && c.currentInfluence < 67)
        {
            c.influenceBar.color = Color.yellow;
        }
        else if (c.currentInfluence >= 67 && c.currentInfluence < 101)
        {
            c.influenceBar.color = Color.green;
        }
    }
}
