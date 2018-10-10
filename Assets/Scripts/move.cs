using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Vector2 spawnPosition;
    GameObject floatingText;

    RectTransform m_RectTransform;

    public bool positive = false;
    public bool negative = false;

    // Use this for initialization
    void Start () {

        m_RectTransform = GetComponent<RectTransform>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if(positive)
        {
            m_RectTransform.anchoredPosition = new Vector2(m_RectTransform.anchoredPosition.x, m_RectTransform.anchoredPosition.y + .5f);

        }
        else if (negative)
        {
            m_RectTransform.anchoredPosition = new Vector2(m_RectTransform.anchoredPosition.x, m_RectTransform.anchoredPosition.y - .5f);

        }
        else
        {
            m_RectTransform.anchoredPosition = new Vector2(m_RectTransform.anchoredPosition.x - .5f, m_RectTransform.anchoredPosition.y);

        }


    }
}
