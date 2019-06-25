using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Kei variabele
[System.Serializable]
public class Asteroid 
{
	public GameObject asteroidBigObj; 		//Object Prefab
	public int Count; 						//Aantal enemies dat spawnen per wave
	public float SpawnWait; 				//Interval tussen spawns
	public float StartWait; 				//Hoelang het duurt vanaf start voordat de eerste wave start
	public float WaveWait; 					//tijd tussen waves
}

//Kwal variabele
[System.Serializable]
public class EnemyBlue 
{
	public GameObject enemyBlueObj;		
	public int Count;                    
    public float SpawnWait;                
    public float StartWait;                
    public float WaveWait;				
}

//Skelette vis variabele
[System.Serializable]
public class EnemyGreen 
{
	public GameObject enemyGreenObj;	
	public int Count;                    
    public float SpawnWait;               
    public float StartWait;                
    public float WaveWait;					
}

//Spikey bal variabele
[System.Serializable]
public class EnemyRed 
{
	public GameObject enemyRedObj;		
	public int Count;                 
    public float SpawnWait;            
    public float StartWait;				
	public float WaveWait;			
    
}


public class GameController_Script : MonoBehaviour 
{	

	public Asteroid asteroid;			//maakt een kei object aan
	public EnemyBlue enemyBlue;         //maakt een kwal object aan
    public EnemyGreen enemyGreen;       //maakt een skeletvis object aan
    public EnemyRed enemyRed;           //maakt een spikeybal object aan
    public Vector2 spawnValues;         //waartussen de objects moeten spawnen
    public string SceneName;            //naam van de scene die momenteel geladen is
    public Scene currentScene;          //index van de scene die momenteel geladen is


    public virtual void Start ()

	{
        
        StartCoroutine (asteroidSpawnWaves());  	//Start een Coroutine
		StartCoroutine (enemyBlueSpawnWaves());		
		StartCoroutine (enemyGreenSpawnWaves());	
		StartCoroutine (enemyRedSpawnWaves());      
        currentScene = SceneManager.GetActiveScene();
        SceneName = currentScene.name; 
        
    }


	public virtual void Update () 
	{
		//reset spel wanneer R wordt gedrukt
		if(Input.GetKey("r"))
		{
            if(PlayerPrefs.GetInt("Level") == 6)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(4);
            }else
            UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerPrefs.GetInt("Level")-1);		
		}
        if (Input.GetKey(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }

    //kei Coroutine
    public virtual IEnumerator asteroidSpawnWaves()
	{
		yield return new WaitForSeconds (asteroid.StartWait); 															//Wacht aan seconden voordat waves beginnen

		while (true)
		{
			//Spawn bepaalt aantal keien
			for (int i = 0; i < asteroid.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		//random spawn tussen spawnvalues x en y ( op x as)
				Quaternion spawnRotation = Quaternion.identity;							 								//rotatie van het object
				Instantiate (asteroid.asteroidBigObj, spawnPosition, spawnRotation); 									//Instantiate Object
				yield return new WaitForSeconds (asteroid.SpawnWait); 													//wacht aantal seconden voordat hij het volgende object spawnt
			}
			yield return new WaitForSeconds (asteroid.WaveWait); 														//wacht voor de volgende wave
		}
	}

    //Kwal Coroutine
    public virtual IEnumerator enemyBlueSpawnWaves()
	{
		yield return new WaitForSeconds (enemyBlue.StartWait);															

		while (true)
		{
			for (int i = 0; i < enemyBlue.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		
				Quaternion spawnRotation = Quaternion.identity;															
				Instantiate (enemyBlue.enemyBlueObj, spawnPosition, spawnRotation);										
				yield return new WaitForSeconds (enemyBlue.SpawnWait);													
			}
			yield return new WaitForSeconds (enemyBlue.WaveWait);														
		}
	}

    //Skelet vis Coroutine
    public virtual IEnumerator enemyGreenSpawnWaves()
	{
		yield return new WaitForSeconds (enemyGreen.StartWait);															

		while (true)
		{
			for (int i = 0; i < enemyGreen.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		
				Quaternion spawnRotation = Quaternion.identity;															
				Instantiate (enemyGreen.enemyGreenObj, spawnPosition, spawnRotation);									
				yield return new WaitForSeconds (enemyGreen.SpawnWait);													
			}
			yield return new WaitForSeconds (enemyGreen.WaveWait);														
		}
	}

    //Spikey bal Coroutine
    public virtual IEnumerator enemyRedSpawnWaves()
	{
		yield return new WaitForSeconds (enemyRed.StartWait);															

		while (true)
		{
			for (int i = 0; i < enemyRed.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		
				Quaternion spawnRotation = Quaternion.identity;															
				Instantiate (enemyRed.enemyRedObj, spawnPosition, spawnRotation);										
				yield return new WaitForSeconds (enemyRed.SpawnWait);													
			}
			yield return new WaitForSeconds (enemyRed.WaveWait);														
		}
	}
		
}
