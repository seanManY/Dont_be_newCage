using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToTitle : MonoBehaviour {

    public float delay = 440;

    // Use this for initialization
    void Start () {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }
	

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0);
    }
}
