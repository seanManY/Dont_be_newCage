using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {

    public int SayWhen;
    public float timer = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        float seconds = timer % 60;

        if(seconds > SayWhen)
        {
            Destroy(this.gameObject);
        }

    }
}
