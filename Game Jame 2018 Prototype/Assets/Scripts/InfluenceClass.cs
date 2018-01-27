using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfluenceClass : MonoBehaviour {

    [Range(0, 100)]
    public int favourValue;

    public float favourMultiplier;

    [Range(0, 100)]
    public int currentInfluence;

    public Image favourImage;

    public Image influenceBar;
    public Image influenceBarParent;

	// Use this for initialization
	void Start () {
        // Attach the favour image to this.
        favourImage = this.transform.GetChild(0).GetComponent<Image>();
	}

    public void UpdateInfluenceValue(int influenceChange)
    {
        // Modify influence gain based on current favour value, the influence gain is multiplied by a calculated value within FetchFavourMulti().
        fetchFavourMult();
        int newChange = (int)((favourValue * influenceChange)/50.0f);
        currentInfluence += newChange;
        if(currentInfluence > 100)
        {
            currentInfluence = 100;
        }
    }

    public void UpdateInfluenceBar()
    {
        //favourBar.rectTransform.sizeDelta = new Vector2(-((favourBarParent.rectTransform.sizeDelta.x - 1) / 40) * currentInfluence, favourBar.rectTransform.sizeDelta.y); Inaccurate meter scaling, obsolete use new version.
        influenceBar.rectTransform.sizeDelta = new Vector2((int)(-57 + currentInfluence/1.8), influenceBar.rectTransform.sizeDelta.y);
    }

    void fetchFavourMult()
    {
        favourMultiplier = favourValue / 50.0f;
    }

}
