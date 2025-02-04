﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : GameController_Script
{
    public int sceneId;
    public float victorTime = 20.0f;
    public Text text;
    public GameObject arrowKeys;

    private float countTime = 0;
    private bool tutorialActive = true;
    // Start is called before the first frame update
    public override void Start()
    {
        text = text.GetComponent<Text>();
        text.text = "00:40";
        PlayerPrefs.SetInt("Level", sceneId);
    }
    public void FixedUpdate()
    {
        if(tutorialActive == true && (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow)))
        {
            tutorialActive = false;
            StartCoroutine(asteroidSpawnWaves());
            StartCoroutine(enemyBlueSpawnWaves());
            StartCoroutine(enemyGreenSpawnWaves());
            StartCoroutine(enemyRedSpawnWaves());
            Destroy(arrowKeys);
        }
        if (tutorialActive == false)
        {
            countTime += Time.fixedDeltaTime;
            if (countTime >= victorTime)
                UnityEngine.SceneManagement.SceneManager.LoadScene("Inbetween");
            if (victorTime - (int)countTime >= 10)
                text.text = "00:" + (victorTime - (int)countTime).ToString();
            else
                text.text = "00:0" + (victorTime - (int)countTime).ToString();
        }
    }
}
