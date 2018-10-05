using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float timer = 0f;
    bool holdBool = false;
    private float fireTimer;
    public int fireRate = 200;
    bool move = false;
    private int randomWord;
    private int randLocation;
    int score = 0;

    public GameObject canvas;
    Vector2 spawnPosition;
    GameObject floatingText;
    public GameObject Score;


    public GameObject SpaceText;
    public GameObject HoldText;

    public GameObject FineText;
    public GameObject Fine1;
    public GameObject Fine2;
    public GameObject Fine3;

    public GameObject KoolText;
    public GameObject Kool1;
    public GameObject Kool2;
    public GameObject Kool3;

    public GameObject OkayText;
    public GameObject Okay1;
    public GameObject Okay2;
    public GameObject Okay3;

    public GameObject GreatText;
    public GameObject Great1;
    public GameObject Great2;
    public GameObject Great3;

    public GameObject WhatText;
    public GameObject What1;
    public GameObject What2;
    public GameObject What3;

    public GameObject SureText;
    public GameObject Sure1;
    public GameObject Sure2;
    public GameObject Sure3;

    public GameObject FloatScore;
    public GameObject floatScoreSpawn;

    // Use this for initialization
    void Start () {

        fireTimer = 0;
        

    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        float seconds = timer % 60;

        if(seconds > 5 && !holdBool && SpaceText.gameObject != null)
        {
            SpaceText.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown("space"))
        {
            holdBool = true;
            Destroy(SpaceText.gameObject);
            HoldText.gameObject.SetActive(true);

            move = true;

        }
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (move)
        {
            fireTimer++;
            UpdateScore();

            if ((fireTimer >= fireRate) && (fireRate != 100))
            {

                fireTimer = 0;

                randomWord = Random.Range(0, 6); 
                randLocation = Random.Range(0, 3);

                Debug.Log(randomWord);

                switch (randomWord)
                {
                    //Fine
                    case 0:
                        floatingText = Instantiate(FineText) as GameObject;

                        switch (randLocation)
                        {
                            case 0: floatingText.transform.SetParent(canvas.transform);
                                    spawnPosition = new Vector2(Fine1.GetComponent<RectTransform>().anchoredPosition.x,
                                                                Fine1.GetComponent<RectTransform>().anchoredPosition.y);
                                    floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                    break;
                            case 1:
                                    floatingText.transform.SetParent(canvas.transform);
                                    spawnPosition = new Vector2(Fine2.GetComponent<RectTransform>().anchoredPosition.x,
                                                                Fine2.GetComponent<RectTransform>().anchoredPosition.y);
                                    floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                    floatingText.transform.SetParent(canvas.transform);
                                    spawnPosition = new Vector2(Fine3.GetComponent<RectTransform>().anchoredPosition.x,
                                                                Fine3.GetComponent<RectTransform>().anchoredPosition.y);
                                    floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    //Kool
                    case 1:
                        floatingText = Instantiate(KoolText) as GameObject;

                        switch (randLocation)
                        {
                            case 0:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Kool1.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Kool1.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 1:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Kool2.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Kool2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Kool3.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Kool3.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    case 2:
                        floatingText = Instantiate(OkayText) as GameObject;

                        switch (randLocation)
                        {
                            case 0:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Okay1.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Okay2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 1:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Okay2.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Okay2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Okay3.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Okay3.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    case 3:
                        floatingText = Instantiate(GreatText) as GameObject;

                        switch (randLocation)
                        {
                            case 0:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Great1.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Great1.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 1:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Great2.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Great2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Great3.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Great3.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    case 4:
                        floatingText = Instantiate(WhatText) as GameObject;

                        switch (randLocation)
                        {
                            case 0:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(What1.GetComponent<RectTransform>().anchoredPosition.x,
                                                            What1.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 1:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(What2.GetComponent<RectTransform>().anchoredPosition.x,
                                                            What2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(What3.GetComponent<RectTransform>().anchoredPosition.x,
                                                            What3.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    case 5:
                        floatingText = Instantiate(SureText) as GameObject;

                        switch (randLocation)
                        {
                            case 0:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Sure1.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Sure1.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 1:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Sure2.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Sure2.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            case 2:
                                floatingText.transform.SetParent(canvas.transform);
                                spawnPosition = new Vector2(Sure3.GetComponent<RectTransform>().anchoredPosition.x,
                                                            Sure3.GetComponent<RectTransform>().anchoredPosition.y);
                                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                                break;
                            default: break;
                        }
                        break;

                    default: break;
                }

                
            }
        }

    }

    public void UpdateScore()
    {
        int newScore; //newDOug
        int negCounter = 0;
        int CoinFlip = Random.Range(0, 200);
        TextMeshProUGUI ScoreText = Score.GetComponent<TextMeshProUGUI>();

        if(CoinFlip == 1)
        {
            newScore = Random.Range(1, 26);
            score += newScore;
            ScoreText.SetText("Score: " + score);
            FloatScore.GetComponent<TextMeshProUGUI>().SetText("+" + score);
            floatingText = Instantiate(FloatScore) as GameObject;
            floatingText.transform.SetParent(canvas.transform);
            spawnPosition = new Vector2(floatingText.GetComponent<RectTransform>().anchoredPosition.x,
                                        floatingText
                                        .GetComponent<RectTransform>().anchoredPosition.y);

        }

        
        
    }
}
