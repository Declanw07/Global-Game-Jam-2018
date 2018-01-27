using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityAttributes : MonoBehaviour {

	float influenceVal = 50f;
	int influenceMax = 100;
	int influenceMin = 0;
	int favourVal = 2;
	bool inMapRange = true;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (favourVal == 1 && inMapRange == true)
		{
			transform.Find ("Favour").transform.Find ("Happy").gameObject.SetActive (true);
		}
		if (favourVal == 2 && inMapRange == true)
		{
			transform.Find ("Favour").transform.Find ("Meh").gameObject.SetActive (true);
		}
		if (favourVal == 3 && inMapRange == true)
		{
			transform.Find ("Favour").transform.Find ("Sad").gameObject.SetActive (true);
		}
		if (inMapRange == false)
		{
			transform.Find ("Favour").transform.Find ("Happy").gameObject.SetActive (false);
			transform.Find ("Favour").transform.Find ("Meh").gameObject.SetActive (false);
			transform.Find ("Favour").transform.Find ("Sad").gameObject.SetActive (false);
		}
	}
}
