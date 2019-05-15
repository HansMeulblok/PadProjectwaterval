using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level21 : GameController_Script
{

    public float victorTime = 30.0f;
    public Text text;
    private float countTime = 0;

    // Start is called before the first frame update
    public override void Start()
    {
        text = text.GetComponent<Text>();
        text.text = "00:" + (victorTime - (int)countTime).ToString();
        StartCoroutine(asteroidSpawnWaves());   //Start IEnumerator function
        StartCoroutine(enemyBlueSpawnWaves());      //Start IEnumerator function
        StartCoroutine(enemyGreenSpawnWaves()); //Start IEnumerator function
        StartCoroutine(enemyRedSpawnWaves());		//Start IEnumerator function
    }
    public void FixedUpdate()
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