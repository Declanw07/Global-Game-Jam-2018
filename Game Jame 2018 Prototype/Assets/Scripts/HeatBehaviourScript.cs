using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBehaviourScript : MonoBehaviour {

    public uint heatValue;

    public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HeatUpdate(short heatChange)
    {

        heatValue += (uint)heatChange;
         

    }

    void UpdateHeatUI()
    {



    }
}
