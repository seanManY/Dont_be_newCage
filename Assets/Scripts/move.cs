using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Vector2 spawnPosition;
    GameObject floatingText;

    RectTransform m_RectTransform;

    // Use this for initialization
    void Start () {

        m_RectTransform = GetComponent<RectTransform>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        m_RectTransform.anchoredPosition = new Vector2(m_RectTransform.anchoredPosition.x-.5f, m_RectTransform.anchoredPosition.y);

    }
}
