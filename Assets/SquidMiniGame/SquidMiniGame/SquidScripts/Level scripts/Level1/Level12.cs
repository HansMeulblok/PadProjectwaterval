using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level12 : GameController_Script
{
    public GUIText VictoryText;             //GUI Victory
    public GUIText ContinueText; 		    //GUI NextLvl

    public int victorScore = 10;
    public Text text;
    public int sceneId;
    public GameObject Spatie;
    private bool tutorialActive = true;
    private bool victory = false;
    // Start is called before the first frame update
    public override void Start()
    {
        text = text.GetComponent<Text>();
        text.text = victorScore.ToString();
        PlayerPrefs.SetInt("Level", sceneId);
    }

    public void FixedUpdate()
    {
        if (tutorialActive == true && Input.GetKey(KeyCode.Space))
        {
            tutorialActive = false;
            StartCoroutine(enemyBlueSpawnWaves());
            Destroy(Spatie);
        }
        if (tutorialActive == false)
        {
            text.text = (victorScore - SharedValues_Script.score).ToString();
            if (SharedValues_Script.score >= victorScore)
                victory = true;
        }
        if (victory == true)
        {
            StopCoroutine(enemyBlueSpawnWaves());
            
            VictoryText.text = "Gewonnen!"; 			
            ContinueText.text = "Klik op een knop om door te gaan";       
            if(Input.anyKeyDown)
                UnityEngine.SceneManagement.SceneManager.LoadScene("Inbetween");
        }
    }
}
