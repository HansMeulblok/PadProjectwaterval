
using UnityEngine;
using System.Collections;

public class Rock_Script1 : MonoBehaviour 
{
	//Public Var
	public float speed; 				//Asteroid Speed
    // Use this for initialization
    void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; 						//Negative Velocity to move down towards the player 
   
    }
}