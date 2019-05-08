/// <summary>
/// 2D Space Shooter Example
/// By Bug Games www.Bug-Games.net
/// Programmer: Danar Kayfi - Twitter: @DanarKayfi
/// Special Thanks to Kenney for the CC0 Graphic Assets: www.kenney.nl
/// 
/// This is the EnemyRed Script:
/// - Enemy Ship Movement/Health/Score
/// - Explosion Trigger
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class EnemyRed_Script : MonoBehaviour 
{

	//Public Var
	public float speed;						//Enemy Ship Speed
	public int health;						//Enemy Ship Health
    public Boundary boundary;               //make an Object from Class Boundary
    Vector2 bounce = new Vector2(-1, 1);
    bool right;
	public GameObject Explosion;
    public int ScoreValue;					//How much the enemy give score after explosion

	// Use this for initialization
	void Start () 
	{
        right = (Random.value > 0.5f);
        if (right)
		    GetComponent<Rigidbody2D>().velocity =new Vector2( -1 * speed, -1 * speed);
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -1 * speed);
    }

	// Update is called once per frame
	void Update () 
	{

        if(GetComponent<Rigidbody2D>().position.x <= boundary.xMin || GetComponent<Rigidbody2D>().position.x >= boundary.xMax)
        {
            GetComponent<Rigidbody2D>().velocity *= bounce;
        }
    }

    //Called when the Trigger entered
    void OnTriggerEnter2D(Collider2D other)
	{
		//Excute if the object tag was equal to one of these
		if(other.tag == "PlayerLaser")
		{
			//Instantiate (LaserGreenHit, transform.position , transform.rotation);		//Instantiate LaserGreenHit 
			Destroy(other.gameObject);													//Destroy the Other (PlayerLaser)
			
			//Check the Health if greater than 0
			if(health > 0)
				health--; 																//Decrement Health by 1
			
			//Check the Health if less or equal 0
			if(health <= 0)
			{
				Instantiate (Explosion, transform.position , transform.rotation); 		//Instantiate Explosion
				SharedValues_Script.score +=ScoreValue;									//Increment score by ScoreValue
				Destroy(gameObject);													//Destroy The Object (Enemy Ship)
			}
		}
		
	}
}
