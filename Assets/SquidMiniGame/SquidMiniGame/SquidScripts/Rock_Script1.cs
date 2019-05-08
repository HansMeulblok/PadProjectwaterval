/// <summary>
/// 2D Space Shooter Example
/// By Bug Games www.Bug-Games.net
/// Programmer: Danar Kayfi - Twitter: @DanarKayfi
/// Special Thanks to Kenney for the CC0 Graphic Assets: www.kenney.nl
/// 
/// This is the Asteroid Script:
/// - Normal & Angular Velocity
/// - Hit/Explosion on Trigger Enter
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class Rock_Script1 : MonoBehaviour 
{
	//Public Var
	public float speed; 				//Asteroid Speed
    // Use this for initialization
    void Start () 
	{
		//GetComponent<Rigidbody2D>().angularVelocity = Random.Range(minTumble, maxTumble); 		//Angular movement based on random speed values
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; 						//Negative Velocity to move down towards the player ship
   
    }
}