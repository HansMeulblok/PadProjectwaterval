using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level13 : GameController_Script
{
    public GUIText VictoryText;             //GUI Victory
    public GUIText ContinueText; 		    //GUI NextLvl

    public int victorScore = 30;
    public Text text;
    private bool victory = false;
    // Start is called before the first frame update
    public override void Start()
    {
        text = text.GetComponent<Text>();
        text.text = victorScore.ToString();
        StartCoroutine(asteroidSpawnWaves());
        StartCoroutine(enemyBlueSpawnWaves());
        StartCoroutine(enemyGreenSpawnWaves());
        StartCoroutine(enemyRedSpawnWaves());
    }

    public void FixedUpdate()
    {

            text.text = (victorScore - SharedValues_Script.score).ToString();
            if (SharedValues_Script.score >= victorScore)
                victory = true;
        if (victory == true)
        {
            StopCoroutine(enemyBlueSpawnWaves());
            
            VictoryText.text = "Goed gedaan!"; 			
            ContinueText.text = "Klik op een knop om door te gaan";       
            if(Input.anyKeyDown)
                UnityEngine.SceneManagement.SceneManager.LoadScene("Inbetween");
        }
    }
}
