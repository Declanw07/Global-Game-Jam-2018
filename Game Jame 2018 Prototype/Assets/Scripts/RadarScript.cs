using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadarScript : MonoBehaviour {

    Image radar;
    float lerpTime = 0.0f;

    float minimumSize = 1.0f;
    float maximumSize = 700.0f;

    // List of "cities", InfluenceClass mostly holds city related values not just Influence.
    public List<InfluenceClass> citiesInRange;

	// Use this for initialization
	void Start () {

        // Fetch the image component and then set the radius of the trigger to half the image width.
        radar = this.GetComponent<Image>();
        this.GetComponent<CircleCollider2D>().radius = maximumSize / 2;
        this.transform.parent.transform.position = new Vector3(this.transform.parent.transform.position.x, this.transform.parent.transform.position.y + 0.1f, this.transform.parent.transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {

        // Code to create expanding and contracting effect using lerp on both the image width and height.
        radar.rectTransform.sizeDelta = new Vector2(Mathf.Lerp(minimumSize, maximumSize, lerpTime), Mathf.Lerp(minimumSize, maximumSize, lerpTime));
        lerpTime += 1.0f * Time.deltaTime;

        if(lerpTime > 2.0f)
        {
            radar.rectTransform.sizeDelta = new Vector2(minimumSize, minimumSize);
            lerpTime = 0.0f;
        }

        // Reverse the Target and Starting values to invert the movement. (E.G: Change from big to small to small to big)
        //if(lerpTime > 2.0f)
        //{
        //    float temp = maximumSize;
        //    maximumSize = minimumSize;
        //    minimumSize = temp;
        //    lerpTime = 0.0F;
            
        //}
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if a city is in range.
        if(other.gameObject.tag == "City")
        {
            // If it is then add the InfluenceClass to the list and then set the cities in range property to be true.
            Debug.Log("123");
            citiesInRange.Add(other.gameObject.GetComponent<InfluenceClass>());
            other.gameObject.GetComponent<CityClass>().inRange = true;
        }
    }
}
