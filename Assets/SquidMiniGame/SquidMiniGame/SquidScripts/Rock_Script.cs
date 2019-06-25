
using UnityEngine;
using System.Collections;

public class Rock_Script : MonoBehaviour 
{
	//Public Var
	
	public float speed; 				//rock Speed
	public int health; 					//rock set to infinite
	public GameObject LaserGreenHit; 	//LaserHit Prefab
	public GameObject Explosion; 		//Explosion Prefab


    // Use this for initialization
    void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; 						//Negative Velocity to move down towards the player
   
    }

	//Called when the Trigger entered
	void OnTriggerEnter2D(Collider2D other)
	{
		//Excute if the object tag was equal to one of these
		if(other.tag == "PlayerLaser")
		{
			//Instantiate (LaserGreenHit, transform.position , transform.rotation); 		//Instantiate LaserGreenHit 
			Destroy(other.gameObject);													//Destroy the Other (PlayerLaser)

			//Check the Health if greater than 0
			if(health > 0)
				health--;                                                               //Decrement Health by 1
           

            //Check the Health if less or equal 0
            if (health <= 0)
			{
				Instantiate (Explosion, transform.position , transform.rotation); 		//Instantiate Explosion
				Destroy(gameObject); 													//Destroy rock
			}
		}
	}
}