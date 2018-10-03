using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Vector2 spawnPosition;
    GameObject floatingText;

    RectTransform rectTransform = GetComponent<RectTransform>().anchoredPosition;

    // Use this for initialization
    void Start () {

        


    }
	
	// Update is called once per frame
	void FixedUpdate () {
        spawnPosition = new Vector2(this.GetComponent<RectTransform>().anchoredPosition.x-1,
                                    this.GetComponent<RectTransform>().anchoredPosition.y);
        floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
    }
}
