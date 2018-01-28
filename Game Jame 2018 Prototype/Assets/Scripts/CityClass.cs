using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityClass : MonoBehaviour {

    InfluenceClass influenceClass;

    public GameObject radarObject;


    public bool inRange = false;

    public bool isOwned = false;
    private bool isSelected;


	// Use this for initialization
	void Start () {

        influenceClass = this.GetComponent<InfluenceClass>();
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    public void SetAsSelected()
    {
        if (!isSelected)
        {
            if (influenceClass.currentInfluence == 100 && inRange)
            {
                Debug.Log("City Selected");
                isSelected = true;
                isOwned = true;
                SetRadarActive();
            }
        }
        else
        {
            Debug.Log("Either city was already selected or not enough influence");
            isSelected = false;
        }
    }

    private void SetRadarActive()
    {
        radarObject.SetActive(true);
    }
}
