﻿
using UnityEngine;
using System.Collections;

public class SharedValues_Script : MonoBehaviour 
{

    // we should replace the GUI parts
	//Public Var
	public GUIText scoreText; 				//GUI Score
	public GUIText GameOverText; 			//GUI GameOver
	public GUIText FinalScoreText; 			//GUI Final Score
	public GUIText ReplayText; 				//GUI Replay

	//Public Shared Var
	public static int score = 0;            //Total in-game Score
    public static int seaScore = 0;         //Total in-game SeaScore
    public static bool gameover = false; 	//GameOver Trigger

	// Use this for initialization
	void Start () 
	{
		gameover = false; 					//return the Gameover trigger to its initial state when the game restart
		score = 0; 							//return the Score to its initial state when the game restart
        seaScore = 0;                       //return the Score to its initial state when the game restart
    }

	// Fixed Update is called one per specific time
	void FixedUpdate ()
	{
        if (gameover == false && scoreText != null)
        {
            scoreText.text = "Score: " + score;             //Update the GUI Score
        }
		//Excute when the GameOver Trigger is True
		if (gameover == true)
		{
			GameOverText.text = "GAME OVER"; 			//Show GUI GameOver
            if(FinalScoreText != null)
			FinalScoreText.text = "" + score; 			//Show GUI FinalScore
			ReplayText.text = "PRESS R TO REPLAY OR PRESS ESC TO RETURN TO MENU"; 		//Show GUI Replay
		}
	}
}
