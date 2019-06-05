
using UnityEngine;
using System.Collections;

public class EnemyBlue_Script : MonoBehaviour 
{

	public float speed; //Enemy blue Speed
	public int health; //Enemy blue Health
	public GameObject LaserGreenHit; //prefab voor enemy blue
	public GameObject Explosion; //Explosie voor enemy blue
	public int ScoreValue;
    SpriteRenderer BlueEnemy_SpriteRenderer;  // spriterenderer aanroepen zodat later de kleur veranderd kan worden


    
    void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; //enemy blue movement
        BlueEnemy_SpriteRenderer = GetComponent<SpriteRenderer>();   
        BlueEnemy_SpriteRenderer.color = Color.white;           // de kleur op wit zetten zodat de kleur hetzelfde blijft 
    }

	// als er collision plaats vind
	void OnTriggerEnter2D(Collider2D other)
	{
    
       
        if (other.tag == "PlayerLaser")
		{
           
            Instantiate (LaserGreenHit, transform.position , transform.rotation); 			
			Destroy(other.gameObject); 														// vernietig het andere object in collision
			
			//Checken of de health groter is dan 0
			if(health > 0)
				health--;                                                                   //1 health eraf halen wanneer het object geraakt is door de squid
            BlueEnemy_SpriteRenderer.color = new Color(0.278f, 0.294f, 0.419f,1f);          // de kleur van enemyblue zwarter maken om te laten zien dat enemyblue geraakt is
        


			//checken of de health kleiner of gelijk aan 0 is
			if(health <= 0)
			{
				Instantiate (Explosion, transform.position , transform.rotation); 			//de explosie triggeren
				SharedValues_Script.score +=ScoreValue; 									//score erbij tellen
				Destroy(gameObject);														//vernietig enemyblue
			}
		}
	}
}