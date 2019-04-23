using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : GameController_Script
{

    public float victorTime = 200.0f;

    public float victorTime = 20.0f;
    public Text text;
    public GameObject arrowKeys;

    private float countTime = 0;
    private bool tutorialActive = true;
    // Start is called before the first frame update
    public override void Start()
    {
        PlayerPrefs.SetInt("Level", 6);
        text = text.GetComponent<Text>();
        text.text = "00:30";
    }
    public void FixedUpdate()
    {
        if(tutorialActive == true && (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow)))
        {
            tutorialActive = false;
            StartCoroutine(asteroidSpawnWaves());
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
